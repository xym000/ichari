﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;
using SLS.SilverLight.FilterShrink.Model;

namespace SLS.SilverLight.FilterShrink.BQCChildWindow
{
    public partial class bqcindexfilter : ChildWindow
    {
        public StackPanel StackPanel;
        public List<List<double>> SelectedRate;

        DispatcherTimer Timer;

        public string ListStr = string.Empty;//父窗体传来的过滤条件
        public bqcindexfilter()
        {
            InitializeComponent();

            #region 按钮的事件绑定
            btnAdd.Click += new RoutedEventHandler(btnAdd_Click);

            btnAllDel.Click += new RoutedEventHandler(btnAllDel_Click);

            btnDelete.Click += new RoutedEventHandler(btnDelete_Click);

            btnShift.Click += new RoutedEventHandler(btnShift_Click);
            #endregion
        }

        //替换
        void btnShift_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            int Index = lbResult.SelectedIndex;
            if (Index == -1) return;

            string Str = string.Empty;
            var selfcols = DataGrid3.Columns[10];
            foreach (var item in DataGrid3.ItemsSource)
            {
                //--对象所在的单元格
                var cells = selfcols.GetCellContent(item);
                if (cells != null)
                {
                    //--单元格所包含的元素
                    Grid Grid = cells as Grid;
                    if ((bool)(Grid.Children[0] as CheckBox).IsChecked)
                    {
                        Str += "Y,";
                    }
                    else
                    {
                        Str += "n,";
                    }
                }
            }

            Str = Str.Substring(0, Str.Length - 1);
            string Start = PaseInt(cbStart.Text).ToString();
            string End = PaseInt(cbEnd.Text).ToString();

            string Result = Str + "|" + "竞彩赔率|" + Start + "-" + End;

            lbResult.Items.RemoveAt(Index);
            lbResult.Items.Insert(Index, Result);
        }

        //删除单个
        void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            int Index = lbResult.SelectedIndex;
            if (Index == -1) return;
            lbResult.Items.RemoveAt(Index);
        }

        //全部删除
        void btnAllDel_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            lbResult.Items.Clear();
        }

        //添加按钮
        void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            string Str = string.Empty;
            var selfcols = DataGrid3.Columns[10];
            foreach (var item in DataGrid3.ItemsSource)
            {
                //--对象所在的单元格
                var cells = selfcols.GetCellContent(item);
                if (cells != null)
                {
                    //--单元格所包含的元素
                    Grid Grid = cells as Grid;
                    if ((bool)(Grid.Children[0] as CheckBox).IsChecked)
                    {
                        Str += "Y,";
                    }
                    else
                    {
                        Str += "n,";
                    }
                }
            }

            Str = Str.Substring(0, Str.Length - 1);
            string Start = PaseInt(cbStart.Text).ToString();
            string End = PaseInt(cbEnd.Text).ToString();

            string Result = Str + "|" + "竞彩赔率|" + Start + "-" + End;
            lbResult.Items.Add(Result);
        }

        //确定按钮
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            string Str = string.Empty;

            if (lbResult.Items.Count > 0)
            {
                foreach (string s in lbResult.Items)
                {
                    Str += s + ";";
                }
                Str = Str.Substring(0, Str.Length - 1);
                HidResult.Text = Str;
            }
            else
            {
                MessageBox.Show("没有任何数据！");
                return;
            }
            this.DialogResult = true;

        }
        //取消按钮
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        //打开该窗体后，加载datagrid
        public void BindDataGrid(List<Netball> NetBallList, StackPanel sp)
        {
            cbStart.Text = "";
            cbEnd.Text = "";

            DataGrid3.ItemsSource = NetBallList;
            StackPanel = sp;

            if (this.Title.ToString() == "分组指数和值")
            {
                tbName.Text = "<=和值<=";
                lbRateName.Text = "竞彩赔率指数和:";
                lbRate.Text = "0.00-0.00";
            }
            else
            {
                tbName.Text = "<=积值<=";
                lbRateName.Text = "竞彩赔率指数积:";
                lbRate.Text = "1.00-1.00";
            }

            //延时初始化指数和、指数积
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 0, 0, 200);
            Timer.Tick += new EventHandler(Timer_Tick);
            Timer.Start();
        }

        //延迟加载的方法
        void Timer_Tick(object sender, EventArgs e)
        {
            var selfcols = DataGrid3.Columns[10];
            foreach (var item in DataGrid3.ItemsSource)
            {
                //--对象所在的单元格                    
                var cells = selfcols.GetCellContent(item);
                if (cells != null)
                {
                    Grid grid = cells as Grid;
                    (grid.Children[0] as CheckBox).IsChecked = false;
                }
            }

            lbResult.Items.Clear();
            foreach (string s in ListStr.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                lbResult.Items.Add(s);
            }

            Timer.Stop();
        }

        //取消GataGrid复选框选中
        public void ReSetGataGrid(string Result)
        {
            var selfcols = DataGrid3.Columns[9];
            foreach (var items in DataGrid3.ItemsSource)
            {
                var cells1 = selfcols.GetCellContent(items);
                Grid Grid = cells1 as Grid;
                (Grid.Children[0] as CheckBox).IsChecked = false;
            }

            cbStart.Text = "";
            cbEnd.Text = "";

            if (this.Title.ToString() == "分组指数和值")
            {
                lbRate.Text = "0.00-0.00";
            }
            else
            {
                lbRate.Text = "1.00-1.00";
            }

            lbResult.Items.Clear();
            string[] Results = Result.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string res in Results)
            {
                lbResult.Items.Add(res);
            }
        }

        void cb1_Click(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            var selfcols = DataGrid3.Columns[10];
            double maxNum = 0;
            double minNum = 0;

            if (Title.ToString() != "分组指数和值")
            {
                maxNum = 1;
                minNum = 1;
            }

            int i = 0;
            foreach (var items in DataGrid3.ItemsSource)
            {
                var cells1 = selfcols.GetCellContent(items);
                Grid Grid = cells1 as Grid;

                if ((bool)(Grid.Children[0] as CheckBox).IsChecked)
                {
                    if (Title.ToString() == "分组指数和值")
                    {
                        maxNum += SelectedRate[i].Max();
                        minNum += SelectedRate[i].Min();
                    }
                    else
                    {
                        maxNum *= SelectedRate[i].Max();
                        minNum *= SelectedRate[i].Min();
                    }
                }

                i++;
            }

            lbRate.Text = string.Format("{0:f2}", minNum) + "-" + string.Format("{0:f2}", maxNum);

        }

        #region Other
        int PaseInt(string str)
        {
            int n = 0;
            int.TryParse(str, out n);

            return n;
        }
        #endregion
    }
}

