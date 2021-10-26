using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace EventSample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()//桌面计时器程序
        {
            InitializeComponent();
            DispatcherTimer myTimer = new DispatcherTimer();//用引用变量"myTimer"引用DispatherTimer类的一个新的实例
            myTimer.Interval = TimeSpan.FromSeconds(1);//给该实例的属性"Interval"赋值
            myTimer.Tick += MyTimer_Tick;//调用事件处理器。在此上下文中使用 += 运算符称为“注册事件”。这里是 C# 事件绑定(注册、订阅)的特写用法，表示事件的处理程序集合中添加一个事件处理程序。
            myTimer.Start();//调用这个实例的方法，开始计时
        }

        private void MyTimer_Tick(object sender, EventArgs e)//当事件触发时，这个方法执行，称为事件处理器。
        {
            this.timeTextBox.Text = DateTime.Now.ToString();
        }
    }
}
