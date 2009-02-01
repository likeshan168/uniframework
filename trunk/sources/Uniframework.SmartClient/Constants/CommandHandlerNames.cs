﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uniframework.SmartClient
{
    /// <summary>
    /// 全局命令名称
    /// </summary>
    public static class CommandHandlerNames
    {
        public const string CMD_CLICKME                       = "/Shell/Module/Foundation/ClickMe";
        public const string CMD_SHOW_LAYOUTSETTING            = "/Shell/Module/Foundation/Setting/ShellLayout";
        
        // 文件菜单命令
        public const string CMD_FILE_NEW                      = "/Shell/Module/Foundation/File/New";
        public const string CMD_FILE_OPEN                     = "/Shell/Module/Foundation/File/Open";
        public const string CMD_FILE_SAVE                     = "/Shell/Module/Foundation/File/Save";
        public const string CMD_FILE_SAVEAS                   = "/Shell/Module/Foundation/File/SaveAs";
        public const string CMD_FILE_SAVEALL                  = "/Shell/Module/Foundation/File/SaveAll";
        public const string CMD_FILE_CLOSE                    = "/Shell/Module/Foundation/File/Close";
        public const string CMD_FILE_CLOSEALL                 = "/Shell/Module/Foundation/File/CloseAll";
        public const string CMD_FILE_PRINT                    = "/Shell/Module/Foundation/File/Print";
        public const string CMD_FILE_QUICKPRINT               = "/Shell/Module/Foundation/File/QuickPrint";
        public const string CMD_FILE_PREVIEW                  = "/Shell/Module/Foundation/File/Preview";
        public const string CMD_FILE_PAGESETUP                = "/Shell/Module/Foundation/File/PageSetup";
        public const string CMD_FILE_DESIGN                   = "/Shell/Module/Foundation/File/Design";
        public const string CMD_FILE_EXPORT                   = "/Shell/Module/Foundation/File/Export";
        public const string CMD_FILE_IMPORT                   = "/Shell/Module/Foundation/File/Import";
        public const string CMD_FILE_SENDEMAIL                = "/Shell/Module/Foundation/File/SendEmail";
        public const string CMD_FILE_SENDFAX                  = "/Shell/Module/Foundation/File/SendFax";
        public const string CMD_FILE_ATTRIBUTE                = "/Shell/Module/Foundation/File/Attribute";
        public const string CMD_FILE_EXIT                     = "/Shell/Module/Foundation/File/Exit";

        // 编辑菜单命令
        public const string CMD_EDIT_UNDO                     = "/Shell/Module/Foundation/Edit/Undo";
        public const string CMD_EDIT_REDO                     = "/Shell/Module/Foundation/Edit/Redo";
        public const string CMD_EDIT_CUT                      = "/Shell/Module/Foundation/Edit/Cut";
        public const string CMD_EDIT_COPY                     = "/Shell/Module/Foundation/Edit/Copy";
        public const string CMD_EDIT_PASTE                    = "/Shell/Module/Foundation/Edit/Paste";
        public const string CMD_EDIT_DELETE                   = "/Shell/Module/Foundation/Edit/Delete";
        public const string CMD_EDIT_SELECTALL                = "/Shell/Module/Foundation/Edit/SelectAll";
        public const string CMD_EDIT_SEARCH                   = "/Shell/Module/Foundation/Edit/Search";
        public const string CMD_EDIT_REPLACE                  = "/Shell/Module/Foundation/Edit/Replace";

        // 视图菜单命令
        public const string CMD_VIEW_TASKBAR                  = "/Shell/Module/Foundation/View/ShowTaskbarView";
        public const string CMD_VIEW_SETTING                  = "/Shell/Module/Foundation/View/Setting";
        public const string CMD_VIEW_FULLSCREEN               = "/Shell/Module/Foundation/View/FullScreen";
        public const string CMD_VIEW_HIDEN                    = "/Shell/Module/Foundation/View/Hiden";
        public const string CMD_VIEW_BACK                     = "/Shell/Module/Foundation/View/Back";
        public const string CMD_VIEW_FORWARD                  = "/Shell/Module/Foundation/View/Forward";
        public const string CMD_VIEW_STOP                     = "/Shell/Module/Foundation/View/Stop";
        public const string CMD_VIEW_REFRESH                  = "/Shell/Module/Foundation/View/Refresh";
        public const string CMD_VIEW_HOME                     = "/Shell/Module/Foundation/View/Home";

        // 工具菜单命令
        public const string CMD_TOOL_ADDINTREE                = "/Shell/Module/Foundation/Tool/AddInTree";

        // 窗口菜单命令

        // 帮助菜单命令
        public const string CMD_HELP_GETHELP                  = "/Shell/Module/Foundation/Help/GetHelp";
        public const string CMD_HELP_CONTENT                  = "/Shell/Module/Foundation/Help/Content";
        public const string CMD_HELP_INDEX                    = "/Shell/Module/Foundation/Help/Index";
        public const string CMD_HELP_DYNAMICHELP              = "/Shell/Module/Foundation/Help/ShowDynamicHelp";
        public const string CMD_HELP_DAYTIPS                  = "/Shell/Module/Foundation/Help/Daytips";
        public const string CMD_HELP_REGISTER                 = "/Shell/Module/Foundation/Help/Register";
        public const string CMD_HELP_HOMEPAGE                 = "/Shell/Module/Foundation/Help/HomePage";
        public const string CMD_HELP_CONTACTAUTHOR            = "/Shell/Module/Foundation/Help/ContactAuthor";
        public const string CMD_HELP_SUBMITREPORT             = "/Shell/Module/Foundation/Help/SubmitReport";
        public const string CMD_HELP_CHECKUPGRADE             = "/Shell/Module/Foundation/Help/CheckUpgrade";
        public const string CMD_HELP_ABOUT                    = "/Shell/Module/Foundation/Help/About";
        
        // 数据列表右键菜单命令
        public const string CMD_DATAGRID_INSERT               = "/Shell/Module/Foundation/DataList/Insert";
        public const string CMD_DATAGRID_EDIT                 = "/Shell/Module/Foundation/DataList/Edit";
        public const string CMD_DATAGRID_DELETE               = "/Shell/Module/Foundation/DataList/Delete";
        public const string CMD_DATAGRID_EXPAND               = "/Shell/Module/Foundation/DataList/Expand";
        public const string CMD_DATAGRID_COLLAPSE             = "/Shell/Module/Foundation/DataList/Collapse";
        public const string CMD_DATAGRID_FILTER               = "/Shell/Module/Foundation/DataList/Filter";
        public const string CMD_DATAGRID_REFRESH              = "/Shell/Module/Foundation/DataList/Refresh";
        public const string CMD_DATAGRID_SETDETAILVIEW        = "/Shell/Module/Foundation/DataList/SetDetailView";
        public const string CMD_DATAGRID_SETLAYOUTVIEW        = "/Shell/Module/Foundation/DataList/SetLayoutView";
        public const string CMD_DATAGRID_SELECTLAYOUTVIEW     = "/Shell/Module/Foundation/DataList/SelectLayoutView";
        public const string CMD_DATAGRID_SETTING              = "/Shell/Module/Foundation/DataList/Setting";
        public const string CMD_DATAGRID_SHOWGROUPPANEL       = "/Shell/Module/Foundation/DataList/ShowGroupPanel";
        public const string CMD_DATAGRID_SHOWFOOTER           = "/Shell/Module/Foundation/DataList/ShowFooter";


    }
}
