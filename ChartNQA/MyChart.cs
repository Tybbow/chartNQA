﻿using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Linq;

namespace ChartNQA
{
    class MyChart : Chart
    {
        public string AxisY = string.Empty;
        public string Title = string.Empty;
        public int AxisXGrid = 0;
        public int AxisYGrid = 0;
        public bool showLabelMax = false;
        public Chart Mychart { get; set; }

        public MyChart(Chart chart)
        {
            Mychart = chart;
            Mychart.ChartAreas[0].AxisX.Title = "DateTime";
        }

        public int UpdateValue(int nbPoints, string title, string dateto, string datefrom, ListBox myBox, CsvReader reader)
        {
            this.Clear();
            int countPoints = 1;
            String strItem;
            int j = 0;

            AddTitle(title);
            addPub();
            foreach (Object selecteditem in myBox.SelectedItems)
            {
                strItem = selecteditem as String;
                if (reader.headers.Contains(strItem))
                {
                    string[] splitLine;
                    splitLine = reader.lines[1].Split(';');
                    string sendPacketR = splitLine[selectPacketSend(reader.headers)];

                    if (j == 0)
                        this.AxisY = StrAxisy(strItem, sendPacketR);
                    j++;

                    AddSeries(strItem);
                    countPoints = UpdatePoints(reader, splitLine, strItem, dateto, datefrom);
                }
            }
            this.UpdateConstante(nbPoints);
            return (countPoints);
        }

        private int UpdatePoints(CsvReader reader, string[] splitLine, string strItem, string dateto, string datefrom)
        {
            int countPoints = 0;
            int headerDate = selectNumDate(reader.headers);
            int itemIndex = selectIndex(reader.headers, strItem);
            if (strItem.Contains("Max"))
                Mychart.Series[strItem].Color = Color.Red;
            if (strItem.Contains("Min"))
                Mychart.Series[strItem].Color = Color.Green;
            if (strItem.Contains("Avr"))
                Mychart.Series[strItem].Color = Color.Blue;
            for (int i = 1; i < reader.lines.Length; i++)
			{
				MyTime time = new MyTime();
				time.DateTo = dateto;
				time.DateFrom = datefrom;
				splitLine = reader.lines[i].Split(';');
				time.DateRead = splitLine[headerDate];

				if (time.Result())
				{
					countPoints++;
					AddPoints(strItem, splitLine[headerDate], Double.Parse(splitLine[itemIndex]));
				}
			}
            this.showlabel(strItem, showLabelMax);
            return (countPoints);
        }


        private void UpdateConstante(int nbPoints)
        {

            //ChartArea3DStyle chart3d = new ChartArea3DStyle();
            //chart3d.Enable3D = true;
            //Mychart.ChartAreas[0].Area3DStyle = chart3d;
            //Mychart.ChartAreas[0].Area3DStyle.Enable3D = true;
            Mychart.ChartAreas[0].AxisX.Interval = Mychart.Series[0].Points.Count / nbPoints;
            Mychart.ChartAreas[0].AxisX.MajorGrid.LineWidth = AxisXGrid;
            Mychart.ChartAreas[0].AxisY.MajorGrid.LineWidth = AxisYGrid;
            Mychart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            if (!string.IsNullOrEmpty(AxisY))
                Mychart.ChartAreas[0].AxisY.Title = AxisY.ToString();
        }

        private void addPub()
        {
            Mychart.Titles.Add("PUB");
            Mychart.Titles[1].Text = "ChartNQA\r\nCNMO-R Division Métrologie";
            Mychart.Titles[1].Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
            Mychart.Titles[1].ForeColor = Color.LightGray;
            Mychart.Titles[1].Position.Auto = false;
            Mychart.Titles[1].Position.X = 90;
            Mychart.Titles[1].Position.Y = 96;
        }

        public bool AddTitle(string title)
        {
            Mychart.Titles.Add("Titles");
            this.Title = title;
            Mychart.Titles[0].Font = new System.Drawing.Font("Tahoma", 12, FontStyle.Bold);
            Mychart.Titles[0].ForeColor = Color.Black;
            Mychart.Titles[0].Text = this.Title;
            return true;
        }

        public bool Clear()
        {
            Mychart.Series.Clear();
            Mychart.Titles.Clear();
            return (true);
        }

        public bool AddSeries(string strItem)
        {
            Mychart.Series.Add(strItem);
            Mychart.Series[strItem].ChartType = SeriesChartType.Line;
           // Mychart.Series[strItem].BorderWidth = 3;
            Mychart.Series[strItem].ChartArea = "ChartArea1";
            Mychart.Series[strItem].XValueType = ChartValueType.DateTime;
            Mychart.Series[strItem].IsXValueIndexed = false;
            return true;
        }

        public bool SaveFile(int type, string s)
        {
            if (string.IsNullOrEmpty(s))
                s = "NA";

            if (type == 1)
            {
                s = secureEntry(this.Title);
                Mychart.SaveImage(string.Format("{0}.png", s), ChartImageFormat.Png);
            }
            else if (type == 2)
            {
                var doc = new Document(PageSize.A3);
                s = secureEntry(this.Title);
                PdfWriter.GetInstance(doc, new FileStream(string.Format("{0}.pdf", s), FileMode.Create));
                doc.Open();

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    Mychart.SaveImage(memoryStream, ChartImageFormat.Png);
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(memoryStream.GetBuffer());
                    img.SetDpi(500, 500);
                    img.ScalePercent(60f);
                    doc.Add(img);
                    doc.Close();
                }
            }
            return (true);
        }
        public bool AddPoints(string mySerie, string DateIndex, double ItemIndex)
        {
            Mychart.Series[mySerie].Points.AddXY(DateIndex, ItemIndex);
            return true;
        }

        private void showlabel(string strItem, bool value)
        {
            Mychart.Series[strItem].Points.FindMaxByValue().IsValueShownAsLabel = value;
            Mychart.Series[strItem].Points.FindMaxByValue().LabelForeColor = Color.DarkRed;
            Mychart.Series[strItem].Points.FindMaxByValue().Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
            Mychart.Series[strItem].Points.FindMinByValue().IsValueShownAsLabel = value;
            Mychart.Series[strItem].Points.FindMinByValue().LabelForeColor = Color.DarkGreen;
            Mychart.Series[strItem].Points.FindMinByValue().Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
        }
        public bool AddLegends()
        {
            return true;
        }

        private string secureEntry(string entry)
        {
            entry = entry.Replace(' ', '_');
            entry = entry.Replace('/', '_');
            entry = entry.Replace('\\', '_');
            entry = entry.Replace("//", "_");
            entry = entry.Replace("\\", "_");
            return (entry);
        }


        private string StrAxisy(string strItem, string sendPacketR)
        {
			string tmp = string.Empty;
			if (strItem.Contains("Pct") || strItem.Contains("PacketLost"))
				tmp = "Pourcentage - SendPackets : " + sendPacketR;
			else if (strItem.Contains("Fails") || strItem.Contains("PacketLate") || strItem == "PacketSDLost" || strItem == "PacketDSLost" || strItem == "PacketUnkLost")
				tmp = "Error(s)";
			else if (strItem.Contains("RTT"))
				tmp = "RTTNumber";
            else
                tmp = "Response Time (ms)";
            return (tmp);
        }

		private int selectNumDate(string[] headers)
		{
			int i;

			i = 0;
			foreach (string header in headers)
			{
				if (header == "Time")
					break;
				i++;
			}
			return (i);
		}

		private int selectPacketSend(string[] headers)
		{
			int i;

			i = 0;
			foreach (string header in headers)
			{
				if (header == "Sendoptime")
					break;
				i++;
			}
			return (i);
		}

		private int selectIndex(string[] headers, string strItem)
		{
			int i;

			i = 0;
			foreach (string header in headers)
			{
				if (header == strItem)
					break;
				i++;
			}
			return (i);
		}

    }
}
