using PRD电气.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace PRD电气
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            Equipment eq1 = new Equipment("1F", "类型1", "配电盘1");

            Equipment eq2 = new Equipment("2F", "类型2", "配电盘2");

            Equipment eq3 = new Equipment("3F", "类型3", "配电盘3");
        }






    }
}
