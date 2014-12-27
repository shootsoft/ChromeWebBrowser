using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cef3;
namespace Sashulin.common
{
    class CwbMenuHandler : CefContextMenuHandler
    {
        private ChromeWebBrowser webBrowser;
        private List<CommandItem> commandItems = new List<CommandItem>();

        public CwbMenuHandler(ChromeWebBrowser browser)
        {
            webBrowser = browser;
        }
        protected override void OnBeforeContextMenu(CefBrowser browser, CefFrame frame, CefContextMenuParams state, CefMenuModel model)
        {
            if (!webBrowser.menuVisible)
                model.Clear();
            int commandId = 1001;
            if (webBrowser.ContextMenu != null)
            {
                foreach (MenuItem item in webBrowser.ContextMenu.MenuItems)
                {
                    if (item.Text == "-")
                        model.AddSeparator();
                    else
                        model.AddItem(commandId, item.Text);
                    CommandItem commandItem = new CommandItem();
                    commandItem.id = commandId;
                    commandItem.item = item;
                    commandItems.Add(commandItem);
                    commandId++;
                }
            }
            
            base.OnBeforeContextMenu(browser, frame, state, model);
            
        }

        protected override bool OnContextMenuCommand(CefBrowser browser, CefFrame frame, CefContextMenuParams state, int commandId, CefEventFlags eventFlags)
        {
            foreach (CommandItem commItem in commandItems)
            {
                if (commItem.id == commandId)
                {
                    commItem.item.PerformClick();
                    break;
                }
            }
            return base.OnContextMenuCommand(browser, frame, state, commandId, eventFlags);
        }
        
    }

    class CommandItem
    {
        public int id;
        public MenuItem item;
    }
}
