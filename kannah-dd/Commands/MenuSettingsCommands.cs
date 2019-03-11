using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace kannah_dd.Commands
{
    public static class MenuSettingsCommands
    {
        static readonly RoutedUICommand settingsMenu = new RoutedUICommand("Settings", "SettingsMenu", typeof(MenuSettingsCommands));
        public static RoutedUICommand SettingsMenu { get => settingsMenu; }
    }
}
