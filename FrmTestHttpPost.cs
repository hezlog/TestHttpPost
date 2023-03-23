﻿////////////////////////////////////////////////////////////
// FrmTestHttpPost.cs: 测试Http的POST方法.
// Author: zyl910
// Blog: http://www.cnblogs.com/zyl910
// URL: http://www.cnblogs.com/zyl910/archive/2012/09/19/TestHttpPost.html
// Version: V1.00
// Updata: 2012-09-19
//
////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Threading;
using System.Threading.Tasks;

namespace TestHttpPost
{
    public partial class FrmTestHttpPost : Form
    {
        private EncodingInfo[] _Encodings = null;   // 编码集合.
        private Encoding _ResEncoding = null;   // 回应的编码.

        public FrmTestHttpPost()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 根据BodyName创建Encoding对象。
        /// </summary>
        /// <param name="bodyname">与邮件代理正文标记一起使用的当前编码的名称。</param>
        /// <returns>返回Encoding对象。若没有匹配的BodyName，便返回null。</returns>
        public static Encoding Encoding_FromBodyName(string bodyname)
        {
            if (string.IsNullOrEmpty(bodyname)) return null;
            try
            {
                foreach (EncodingInfo ei in Encoding.GetEncodings())
                {
                    Encoding e = ei.GetEncoding();
                    if (0 == string.Compare(bodyname, e.BodyName, true))
                    {
                        return e;
                    }
                }
            }
            catch
            {
            }
            return null;
        }

        /// <summary>
        /// 输出日志文本.
        /// </summary>
        /// <param name="s">日志文本</param>
        private void OutLog(string s)
        {
            txtLog.Invoke(new Action<string>(p =>
            {
                txtLog.AppendText(p + Environment.NewLine);
                txtLog.ScrollToCaret();
            }), s);
        }

        private void OutLog(string format, params object[] args)
        {
            OutLog(string.Format(format, args));
        }

        private void HttpReq(Encoding myEncoding, string sMode, string sUrl, string sContentType, string sPostData, bool bVerbose)
        {
            HttpWebRequest req;

            // == main ==
            if (bVerbose) OutLog(string.Format("{3}: {0} {1} {2}", sMode, sUrl, sPostData, DateTime.Now.ToString("g")));
            try
            {
                // init
                req = HttpWebRequest.Create(sMode == "GET" ? sUrl + sPostData : sUrl) as HttpWebRequest;
                req.Method = sMode;
                req.Accept = "*/*";
                req.KeepAlive = false;
                req.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
                if (0 == string.Compare("POST", sMode))
                {
                    byte[] bufPost = myEncoding.GetBytes(sPostData);
                    req.ContentType = sContentType;
                    req.ContentLength = bufPost.Length;
                    Stream newStream = req.GetRequestStream();
                    newStream.Write(bufPost, 0, bufPost.Length);
                    newStream.Close();
                }

                // Response
                HttpWebResponse res = req.GetResponse() as HttpWebResponse;
                try
                {
                    if (bVerbose)
                    {
                        OutLog("Response.ContentLength:\t{0}", res.ContentLength);
                        OutLog("Response.ContentType:\t{0}", res.ContentType);
                        OutLog("Response.CharacterSet:\t{0}", res.CharacterSet);
                        OutLog("Response.ContentEncoding:\t{0}", res.ContentEncoding);
                        OutLog("Response.IsFromCache:\t{0}", res.IsFromCache);
                        OutLog("Response.IsMutuallyAuthenticated:\t{0}", res.IsMutuallyAuthenticated);
                        OutLog("Response.LastModified:\t{0}", res.LastModified);
                        OutLog("Response.Method:\t{0}", res.Method);
                        OutLog("Response.ProtocolVersion:\t{0}", res.ProtocolVersion);
                        OutLog("Response.ResponseUri:\t{0}", res.ResponseUri);
                        OutLog("Response.Server:\t{0}", res.Server);
                        OutLog("Response.StatusCode:\t{0}\t# {1}", res.StatusCode, (int)res.StatusCode);
                        OutLog("Response.StatusDescription:\t{0}", res.StatusDescription);

                        // header
                        OutLog(".\t#Header:");  // 头.
                        for (int i = 0; i < res.Headers.Count; ++i)
                        {
                            OutLog("[{2}] {0}:\t{1}", res.Headers.Keys[i], res.Headers[i], i);
                        }
                    }

                    // 找到合适的编码
                    Encoding encoding = null;
                    //encoding = Encoding_FromBodyName(res.CharacterSet);	// 后来发现主体部分的字符集与Response.CharacterSet不同.
                    //if (null == encoding) encoding = myEncoding;
                    encoding = _ResEncoding;
                    System.Diagnostics.Debug.WriteLine(encoding);

                    // body
                    if (bVerbose) OutLog(".\t#Body:");    // 主体.
                    using (Stream resStream = res.GetResponseStream())
                    {
                        using (StreamReader resStreamReader = new StreamReader(resStream, encoding))
                        {
                            OutLog(resStreamReader.ReadToEnd());
                        }
                    }
                    if (bVerbose) OutLog(".\t#OK.");  // 成功.
                }
                finally
                {
                    res.Close();
                }
            }
            catch (Exception ex)
            {
                OutLog(ex.ToString());
            }
            OutLog(string.Empty);

        }

        private void FrmTestHttpPost_Load(object sender, EventArgs e)
        {
            // Http方法
            cboMode.SelectedIndex = 1;  // POST
            cboContentType.SelectedIndex = 0; // json

            // 回应的编码
            cboResEncoding.Items.Clear();
            _Encodings = Encoding.GetEncodings();
            cboResEncoding.DataSource = _Encodings;
            cboResEncoding.DisplayMember = "DisplayName";
            _ResEncoding = Encoding.UTF8;
            cboResEncoding.SelectedIndex = cboResEncoding.FindStringExact(_ResEncoding.EncodingName);

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Encoding myEncoding = Encoding.UTF8;
            string sMode = (string)cboMode.SelectedItem;
            string sUrl = txtUrl.Text;
            string sPostData = txtPostData.Text;
            string sContentType = cboContentType.SelectedItem.ToString(); // "application/x-www-form-urlencoded";
            TextReader read = new System.IO.StringReader(sPostData);

            // Log Length
            //if (txtLog.Lines.Length > 3000) txtLog.Clear();

            if (checkBox1.Checked)
            {
                Task.Run(() =>
                {
                    do
                    {
                        if (string.IsNullOrWhiteSpace(sUrl))
                            break;
                        sPostData = read.ReadLine();
                        if (string.IsNullOrWhiteSpace(sPostData))
                            break;
                        // == main ==
                        HttpReq(myEncoding, sMode, sUrl, sContentType, sPostData, checkBox2.Checked);

                        Thread.Sleep((int)numericUpDown1.Value);

                    } while (!string.IsNullOrWhiteSpace(sPostData));
                });
            }
            else
            {
                // == main ==
                HttpReq(myEncoding, sMode, sUrl, sContentType, sPostData, checkBox2.Checked);
            }

        }

        private void cboResEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            EncodingInfo ei = cboResEncoding.SelectedItem as EncodingInfo;
            if (null == ei) return;
            _ResEncoding = ei.GetEncoding();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }
    }
}