﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Measurement
{
    class HighFrequencyCode
    {
        void OpenText()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";
            string targetpath;
            if (ofd.ShowDialog() == true)
            {
                targetpath = ofd.FileName;
                string[] all = File.ReadAllLines(ofd.FileName);
                if (all == null) return;
            }
        }

        void SaveText()
        {
            SaveFileDialog sfd = new SaveFileDialog();
        }
    }
}