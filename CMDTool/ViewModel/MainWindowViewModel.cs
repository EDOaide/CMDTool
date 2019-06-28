using CMDTool.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Configuration;

namespace CMDTool
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        public MainWindowViewModel()
        {
            this.cmdGenerate = new SimpleCommand(onExecuteGenerateMethod, onCanExecuteMethod);
            this.cmdClear = new SimpleCommand(onExecuteClearMethod, onCanExecuteMethod);

            #region 读取配置信息
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            #endregion
        }
        #region 属性

        private string _COLUMN_1;
        public string COLUMN_1
        {
            get { return _COLUMN_1; }
            set
            {
                if (_COLUMN_1 != value)
                {
                    _COLUMN_1 = value;
                    NotifyPropertyChanged("COLUMN_1");
                }
            }
        }
        private string _COLUMN_2;
        public string COLUMN_2
        {
            get { return _COLUMN_2; }
            set
            {
                if (_COLUMN_2 != value)
                {
                    _COLUMN_2 = value;
                    NotifyPropertyChanged("COLUMN_2");
                }
            }
        }
        private string _COLUMN_3;
        public string COLUMN_3
        {
            get { return _COLUMN_3; }
            set
            {
                if (_COLUMN_3 != value)
                {
                    _COLUMN_3 = value;
                    NotifyPropertyChanged("COLUMN_3");
                }
            }
        }
        private string _COLUMN_4;
        public string COLUMN_4
        {
            get { return _COLUMN_4; }
            set
            {
                if (_COLUMN_4 != value)
                {
                    _COLUMN_4 = value;
                    NotifyPropertyChanged("COLUMN_4");
                }
            }
        }
        private string _COLUMN_5;
        public string COLUMN_5
        {
            get { return _COLUMN_5; }
            set
            {
                if (_COLUMN_5 != value)
                {
                    _COLUMN_5 = value;
                    NotifyPropertyChanged("COLUMN_5");
                }
            }
        }
        private string _COLUMN_6;
        public string COLUMN_6
        {
            get { return _COLUMN_6; }
            set
            {
                if (_COLUMN_6 != value)
                {
                    _COLUMN_6 = value;
                    NotifyPropertyChanged("COLUMN_6");
                }
            }
        }
        private string _COLUMN_7;
        public string COLUMN_7
        {
            get { return _COLUMN_7; }
            set
            {
                if (_COLUMN_7 != value)
                {
                    _COLUMN_7 = value;
                    NotifyPropertyChanged("COLUMN_7");
                }
            }
        }
        private string _COLUMN_8;
        public string COLUMN_8
        {
            get { return _COLUMN_8; }
            set
            {
                if (_COLUMN_8 != value)
                {
                    _COLUMN_8 = value;
                    NotifyPropertyChanged("COLUMN_8");
                }
            }
        }
        private string _COLUMN_9;
        public string COLUMN_9
        {
            get { return _COLUMN_9; }
            set
            {
                if (_COLUMN_9 != value)
                {
                    _COLUMN_9 = value;
                    NotifyPropertyChanged("COLUMN_9");
                }
            }
        }
        private string _CONNECTION_1;
        public string CONNECTION_1
        {
            get { return _CONNECTION_1; }
            set
            {
                if (_CONNECTION_1 != value)
                {
                    _CONNECTION_1 = value;
                    NotifyPropertyChanged("CONNECTION_1");
                }
            }
        }
        private string _CONNECTION_2;
        public string CONNECTION_2
        {
            get { return _CONNECTION_2; }
            set
            {
                if (_CONNECTION_2 != value)
                {
                    _CONNECTION_2 = value;
                    NotifyPropertyChanged("CONNECTION_2");
                }
            }
        }
        private string _CONNECTION_3;
        public string CONNECTION_3
        {
            get { return _CONNECTION_3; }
            set
            {
                if (_CONNECTION_3 != value)
                {
                    _CONNECTION_3 = value;
                    NotifyPropertyChanged("CONNECTION_3");
                }
            }
        }
        private string _CONNECTION_4;
        public string CONNECTION_4
        {
            get { return _CONNECTION_4; }
            set
            {
                if (_CONNECTION_4 != value)
                {
                    _CONNECTION_4 = value;
                    NotifyPropertyChanged("CONNECTION_4");
                }
            }
        }
        private string _CONNECTION_5;
        public string CONNECTION_5
        {
            get { return _CONNECTION_5; }
            set
            {
                if (_CONNECTION_5 != value)
                {
                    _CONNECTION_5 = value;
                    NotifyPropertyChanged("CONNECTION_5");
                }
            }
        }
        private string _CONNECTION_6;
        public string CONNECTION_6
        {
            get { return _CONNECTION_6; }
            set
            {
                if (_CONNECTION_6 != value)
                {
                    _CONNECTION_6 = value;
                    NotifyPropertyChanged("CONNECTION_6");
                }
            }
        }
        private string _CONNECTION_7;
        public string CONNECTION_7
        {
            get { return _CONNECTION_7; }
            set
            {
                if (_CONNECTION_7 != value)
                {
                    _CONNECTION_7 = value;
                    NotifyPropertyChanged("CONNECTION_7");
                }
            }
        }
        private string _CONNECTION_8;
        public string CONNECTION_8
        {
            get { return _CONNECTION_8; }
            set
            {
                if (_CONNECTION_8 != value)
                {
                    _CONNECTION_8 = value;
                    NotifyPropertyChanged("CONNECTION_8");
                }
            }
        }
        private string _CONNECTION_9;
        public string CONNECTION_9
        {
            get { return _CONNECTION_9; }
            set
            {
                if (_CONNECTION_9 != value)
                {
                    _CONNECTION_9 = value;
                    NotifyPropertyChanged("CONNECTION_9");
                }
            }
        }
        private bool _isList;
        public bool isList
        {
            get { return _isList; }
            set
            {
                if (_isList != value)
                {
                    _isList = value;
                    NotifyPropertyChanged("isList");
                }
            }
        }
        private bool _isPaging;
        public bool isPaging
        {
            get { return _isPaging; }
            set
            {
                if (_isPaging != value)
                {
                    _isPaging = value;
                    NotifyPropertyChanged("isPaging");
                }
            }
        }
        private bool _isConnection;
        public bool isConnection
        {
            get { return _isConnection; }
            set
            {
                if (_isConnection != value)
                {
                    _isConnection = value;
                    NotifyPropertyChanged("isConnection");
                }
            }
        }
        private string _connectionString;
        public string connectionString
        {
            get { return _connectionString; }
            set
            {
                if (_connectionString != value)
                {
                    _connectionString = value;
                    NotifyPropertyChanged("connectionString");
                }
            }
        }
        private string _cmdData;
        public string cmdData
        {
            get { return _cmdData; }
            set
            {
                if (_cmdData != value)
                {
                    _cmdData = value;
                    NotifyPropertyChanged("cmdData");
                }
            }
        }
        private string _modelData;
        public string modelData
        {
            get { return _modelData; }
            set
            {
                if (_modelData != value)
                {
                    _modelData = value;
                    NotifyPropertyChanged("modelData");
                }
            }
        }
        #endregion

        #region 方法
        public ICommand cmdGenerate { get; set; }
        public ICommand cmdClear { get; set; }
        //private ICommand _cmdBtnCreatePass;
        //public ICommand cmdBtnCreatePass
        //{
        //    get
        //    {
        //        if (_cmdBtnCreatePass == null)
        //        {
        //            _cmdBtnCreatePass = new SimpleCommand(
        //               onExecuteMetho,
        //               onCanExecuteMethod
        //            );
        //        }
        //    }
        //}

        private bool onCanExecuteMethod(object parameter)
        {
            return !string.IsNullOrEmpty(COLUMN_1);
        }

        private void onExecuteGenerateMethod(object parameter)
        {
            #region 拼接字符串成List
            List<CmdModel> cmdList = new List<CmdModel>();
            StringBuilder cmddata = new StringBuilder("var ctx = ODAContext.NoTransContext;\n");
            List<Field> properties = new List<Field>();//实体类容器
            for (int i = 1; i <= 9; i++)
            {
                var column = GetType().GetProperty("COLUMN_" + i.ToString(), System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public).GetValue(this, null);//同名不同后缀反射为对象装填入list
                var connection = GetType().GetProperty("CONNECTION_" + i.ToString(), System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public).GetValue(this, null);
                string cU = string.Empty;
                string cL = string.Empty;
                bool upperFlag = false;

                #region 拼接cmd新建对象
                if (column != null && !string.IsNullOrEmpty(column.ToString()))
                {
                    string c = column.ToString();
                    //支持三种格式的表名：A_B,CmdAB,cmdAB
                    if (c.Contains("_"))
                    {
                        StringBuilder columnBuilder = new StringBuilder();
                        var cList = c.ToCharArray();
                        for (int j = 0; j < c.Count(); j++)
                        {
                            if (j == 0)
                            {
                                columnBuilder.Append(cList[j].ToString().ToUpper());
                                upperFlag = false;
                            }
                            else if (cList[j].Equals('_'))
                            {
                                upperFlag = true;
                            }
                            else if (upperFlag)
                            {
                                columnBuilder.Append(cList[j].ToString().ToUpper());
                                upperFlag = false;
                            }
                            else
                            {
                                columnBuilder.Append(cList[j].ToString().ToLower());
                                upperFlag = false;
                            }
                        }
                        columnBuilder.Insert(0, "cmd");
                        cL = columnBuilder.ToString();
                        columnBuilder.Remove(0, 3);
                        columnBuilder.Insert(0, "Cmd");
                        cU = columnBuilder.ToString();
                    }
                    else if (c.First() == 'C')
                    {
                        cU = c;
                        c = c.First().ToString().ToLower() + c.Substring(1).ToString();
                        cL = c;
                    }
                    else if (c.First() == 'c')
                    {
                        cL = c;
                        c = c.First().ToString().ToUpper() + c.Substring(1).ToString();
                        cU = c;
                    }
                    else
                    {
                        cL = c;
                        cU = c;
                        //MessageBox.Show(string.Format("请输入正确的表格格式，错误数据为：{0}。", c));
                    }

                    #region 填充cmdList
                    CmdModel cmdModel = new CmdModel();
                    cmdModel.column = cL;
                    if (connection != null && !string.IsNullOrEmpty(column.ToString()))
                    {
                        cmdModel.connection = connection.ToString();
                    }
                    cmdList.Add(cmdModel);
                    #endregion

                    cmddata.Append("var ");
                    cmddata.Append(cL);
                    cmddata.Append(" = ctx.GetCmd<");
                    cmddata.Append(cU);
                    cmddata.Append(">();");
                    cmddata.AppendLine();
                }
                #endregion
            }

            cmddata.AppendLine();
            #endregion

            #region 表处理
            List<string> cLeft = new List<string>();
            List<string> cRight = new List<string>();
            for (int i = 0; i < cmdList.Count; i++)
            {
                #region 拼接oda语句
                string column = cmdList[i].column;
                string connection = cmdList[i].connection;

                if (i == 0)
                {
                    if (isPaging)
                    {
                        cmddata.Append("int totalRecord = 0;");
                        cmddata.AppendLine();
                    }
                    cmddata.Append("var data = ");
                    cmddata.Append(cmdList[i].column);
                    cmddata.AppendLine();
                }
                else
                {
                    #region 生成连接字符
                    if (string.IsNullOrEmpty(connection))
                    {
                        //MessageBox.Show("无连接字符串。");
                        continue;
                    }
                    else if (connection.Contains(";")) 
                    {
                        var LR = connection.Split(';');
                        cLeft = LR[0].Split(',').ToList();
                        cRight = LR[1].Split(',').ToList();
                        if (cLeft.Count != cRight.Count)
                        {
                            MessageBox.Show("连接字符串左右数量不一致。");
                            return;
                        }
                    }
                    else
                    {
                        cLeft = connection.Split(',').ToList();
                        cRight = connection.Split(',').ToList();
                    }
                    #endregion
                    cmddata.Append(".LeftJoin(");
                    cmddata.Append(column);
                    cmddata.Append(",");
                    cmddata.AppendLine();
                    for (int j = 0 ;j < cLeft.Count; j++)
                    {
                        if (!cLeft[j].Contains("Col"))
                        {
                            cLeft[j] = ConvertString.UnderLine(cLeft[j]);
                            cLeft[j] = cLeft[j].Insert(0, "Col");
                        }
                        if (!cRight[j].Contains("Col"))
                        {
                            cRight[j] = ConvertString.UnderLine(cRight[j]);
                            cRight[j] = cRight[j].Insert(0, "Col");
                        }
                        cmddata.Append("\t");
                        cmddata.Append(column);
                        cmddata.Append(".");
                        cmddata.Append(cRight[j]);
                        cmddata.Append(" == ");
                        cmddata.Append(ConvertString.UnderLine(COLUMN_1).Insert(0, "cmd"));
                        cmddata.Append(".");
                        cmddata.Append(cLeft[j]);
                        cmddata.Append(",");
                        cmddata.AppendLine();
                    }

                    #region 填写orgid,enterpriseId,state
                    cmddata.Append("\t");
                    cmddata.Append(column);
                    cmddata.Append(".ColOrgId == OrgId,");
                    cmddata.AppendLine();
                    cmddata.Append("\t");
                    cmddata.Append(column);
                    cmddata.Append(".ColEnterpriseId == EnterpriseId,");
                    cmddata.AppendLine();
                    cmddata.Append("\t");
                    cmddata.Append(column);
                    cmddata.Append(".ColState == \"A\")");
                    cmddata.AppendLine();
                    #endregion
                }
                #endregion
            }
            #endregion

            #region 主表Where
            cmddata.Append(".Where(");
            //cmddata.AppendLine();
            if (!string.IsNullOrEmpty(CONNECTION_1))
            {
                List<string> mainConnection = CONNECTION_1.Split(',').ToList();
                for (int k = 0; k < mainConnection.Count; k++)
                {
                    if (mainConnection[k].Contains("Col"))
                    {
                        cmddata.Append("\t");
                        cmddata.Append(ConvertString.UnderLine(COLUMN_1).Insert(0, "cmd"));
                        cmddata.Append(".");
                        cmddata.Append(mainConnection[k]);
                        cmddata.Append(" == ");
                        cmddata.Append(mainConnection[k].Remove(0, 3));
                        cmddata.Append(",");
                        cmddata.AppendLine();
                    }
                    //else if (mainConnection[k].Contains("_"))
                    //{
                    //    string connection = ConvertString.UnderLine(mainConnection[k]);

                    //    cmddata.Append(COLUMN_1);
                    //    cmddata.Append(".");
                    //    cmddata.Append(connection.Insert(0, "Col"));
                    //    cmddata.Append(" == ");
                    //    cmddata.Append(connection);
                    //    cmddata.Append(",");
                    //    cmddata.AppendLine();
                    //}
                    else
                    {
                        string connection = ConvertString.UnderLine(mainConnection[k]);

                        cmddata.Append("\t");
                        cmddata.Append(ConvertString.UnderLine(COLUMN_1).Insert(0, "cmd"));
                        cmddata.Append(".");
                        cmddata.Append(connection.Insert(0,"Col"));
                        cmddata.Append(" == ");
                        cmddata.Append(mainConnection[k]);
                        cmddata.Append(",");
                        cmddata.AppendLine();
                    }
                }
            }
            #region 填写orgid,enterpriseId,state
            cmddata.Append("\t");
            cmddata.Append(ConvertString.UnderLine(COLUMN_1).Insert(0, "cmd"));
            cmddata.Append(".ColOrgId == OrgId,");
            cmddata.AppendLine();
            cmddata.Append("\t");
            cmddata.Append(ConvertString.UnderLine(COLUMN_1).Insert(0, "cmd"));
            cmddata.Append(".ColEnterpriseId == EnterpriseId,");
            cmddata.AppendLine();
            cmddata.Append("\t");
            cmddata.Append(ConvertString.UnderLine(COLUMN_1).Insert(0, "cmd"));
            cmddata.Append(".ColState == \"A\")");
            cmddata.AppendLine();
            #endregion
            #endregion

            #region 是否生成List，是否分页, 是否生成实体类
            if (isList)
            {
                cmddata.Append(".SelectM") ;
            }
            else
            {
                cmddata.Append(".Select");
            }

            if (isConnection)
            {
                StringBuilder connectionData = new StringBuilder();
                for (int i = 0; i < cmdList.Count; i++)
                {
                    var fileds = DatabaseCommon.GetFileds(connectionString, ConvertString.ToUnderLine(cmdList[i].column));
                    properties.AddRange(fileds);
                }
                properties = properties.Distinct().ToList();

                connectionData.Append("public class ");
                connectionData.Append(ConvertString.UnderLine(COLUMN_1).Replace("cmd", "").Replace("Cmd", ""));
                connectionData.Append("MutiModel");

                cmddata.Append("<");
                cmddata.Append(ConvertString.UnderLine(COLUMN_1).Replace("cmd", "").Replace("Cmd", ""));
                cmddata.Append("MutiModel>");

                connectionData.AppendLine();
                connectionData.Append("{");
                connectionData.AppendLine();
                for (int i = 0; i < properties.Count; i++)
                {
                    connectionData.Append("\t");
                    connectionData.Append("public ");
                    if (properties[i].Type == "char" || properties[i].Type == "varchar")
                    {
                        connectionData.Append("string ");
                    }
                    else if (properties[i].Type == "datetime")
                    {
                        connectionData.Append("DateTime? ");
                    }
                    else if (properties[i].Type == "decimal")
                    {
                        connectionData.Append("decimal? ");
                    }
                    else
                    {
                        connectionData.Append(properties[i].Type);
                        connectionData.Append(" ");
                    }
                    connectionData.Append(properties[i].Name);
                    connectionData.Append(" { get; set; }");
                    connectionData.AppendLine();
                }
                connectionData.Append("}");
                modelData = connectionData.ToString();
            }
            cmddata.Append("(");

            if (isPaging)
            {
                cmddata.Append("start, length, out totalRecord");
                if (isConnection)
                {
                    cmddata.Append(",");
                    cmddata.AppendLine();
                    for (int i = 0; i < properties.Count; i++)
                    {
                        cmddata.Append("\t");
                        cmddata.Append(ConvertString.UnderLine(properties[i].tableName).Insert(0, "cmd"));
                        cmddata.Append(".");
                        cmddata.Append(ConvertString.UnderLine(properties[i].tableName).Insert(0, "Col"));
                        if (i != properties.Count - 1)
                        {
                            cmddata.Append(",");
                        }
                        cmddata.AppendLine();
                    }
                }
                cmddata.Append(");");
                cmddata.AppendLine();
                cmddata.Append("retrun new");
                cmddata.AppendLine();
                cmddata.Append("{");
                cmddata.AppendLine();
                cmddata.Append("\t");
                cmddata.Append("totalRecord");
                cmddata.AppendLine();
                cmddata.Append("\t");
                cmddata.Append("data");
                cmddata.AppendLine();
                cmddata.Append("}");
            }
            else
            {
                if (isConnection)
                {
                    cmddata.AppendLine();
                    for (int i = 0; i < properties.Count; i++)
                    {
                        cmddata.Append("\t");
                        cmddata.Append(ConvertString.UnderLine(properties[i].tableName).Insert(0, "cmd"));
                        cmddata.Append(".");
                        cmddata.Append(ConvertString.UnderLine(properties[i].Name).Insert(0, "Col"));
                        if (i != properties.Count - 1)
                        {
                            cmddata.Append(",");
                        }
                        cmddata.AppendLine();
                    }
                }
                cmddata.Append(");");
                cmddata.AppendLine();
                cmddata.AppendLine();
                cmddata.Append("retrun data;");
            }

            //if (isList && isPaging)
            //{
            //    cmddata.Append(".SelectM(start, length, out totalRecord);");
            //    cmddata.AppendLine();
            //    cmddata.Append("retrun new");
            //    cmddata.AppendLine();
            //    cmddata.Append("{");
            //    cmddata.AppendLine();
            //    cmddata.Append("\t");
            //    cmddata.Append("totalRecord");
            //    cmddata.AppendLine();
            //    cmddata.Append("\t");
            //    cmddata.Append("data");
            //    cmddata.AppendLine();
            //    cmddata.Append("}");
            //}
            //else if(isList && !isPaging)
            //{
            //    cmddata.Append(".SelectM();");
            //    cmddata.AppendLine();
            //    cmddata.AppendLine();
            //    cmddata.Append("retrun data;");
            //}
            //else if (!isList && isPaging)
            //{
            //    cmddata.Append(".Select(start, length, out totalRecord);");
            //    cmddata.AppendLine();
            //    cmddata.Append("retrun data;");
            //}
            //else
            //{
            //    cmddata.Append(".Select();");
            //    cmddata.AppendLine();
            //    cmddata.AppendLine();
            //    cmddata.Append("retrun data;");
            //}
            #endregion
            
            cmdData = cmddata.ToString();

            #region 保存配置信息
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings["connectionString"].Value = connectionString;
            cfa.Save();
            #endregion
        }

        private void onExecuteClearMethod(object parameter)
        {
            COLUMN_1 = string.Empty;
            COLUMN_2 = string.Empty;
            COLUMN_3 = string.Empty;
            COLUMN_4 = string.Empty;
            COLUMN_5 = string.Empty;
            COLUMN_6 = string.Empty;
            COLUMN_7 = string.Empty;
            COLUMN_8 = string.Empty;
            COLUMN_9 = string.Empty;

            CONNECTION_1 = string.Empty;
            CONNECTION_2 = string.Empty;
            CONNECTION_3 = string.Empty;
            CONNECTION_4 = string.Empty;
            CONNECTION_5 = string.Empty;
            CONNECTION_6 = string.Empty;
            CONNECTION_7 = string.Empty;
            CONNECTION_8 = string.Empty;
            CONNECTION_9 = string.Empty;
        }
        #endregion region
    }
}