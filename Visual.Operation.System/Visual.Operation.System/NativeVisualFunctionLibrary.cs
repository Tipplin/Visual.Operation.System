
//#############################################################################
//
// Project	    :	Visual.Operation.Library
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and 
//		            :	Main-Author Christian "TIPPLIN" Kurs
//-----------------------------------------------------------------------------
// Part		        :	NativeDLL - most written in C/C++
//-----------------------------------------------------------------------------
// Base Class       :	VOSSafeNativeVisualFunctionLibrary
//-----------------------------------------------------------------------------
// Copyright © 2020
// by  Visual Galaxy Framework Community Kernel Developer Team.
//-----------------------------------------------------------------------------
// by Head-Author: Christian "TIPPLIN" Kurs - Visual C# Developer
// Portions Copyright © 1982 - 2020 by Microsoft Corporation GmbH.
//-----------------------------------------------------------------------------
// Warning:
// ----------------------------------------------------------------------------
// This product is licensed to you pursuant to the terms of the 
// VGF license agreement included with the original software, and is
// protected by copyright law and international treaties.Unauthorized
// reproduction or distribution may result in severe civil and criminal
// penalties, and will be prosecuted to the maximum extent possible under
// the law.
// You cannot distribute a compiled version 
// of this code without prior registration.
//-----------------------------------------------------------------------------
// Please see the documentation supplied with
// the VGF Libraries for further details.
//
// Authored by 
// Copyright © 2020 by  Visual Galaxy Framework Community Kernel Developer Team
// All Rights Reserved.
// May be redistributed for free,
// but may not be sold without the author's explicit permission
//-----------------------------------------------------------------------------
// This software is Copyright © 2020 by VGF-Technologies at VGF-KernelTeam
// You may only use this software if you are an authorized licensee
// of an VGF developer tools product.
//
// This software is considered a Redistributable as defined under
// the software license agreement that comes with the VGF Products
// and is subject to that software license agreement.
//
//-----------------------------------------------------------------------------
// Microsoft make Restrictions of Export for following Countries:
// --------------------------------------------------------------
// This software is subject to the U.S. Export Administration Regulations and 
// other U.S.law, and may not be exported or re-exported to certain countries
// (Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) 
// or
// to persons or entities prohibited from receiving U.S.exports
// (including Denied Parties, Specially Designated Nationals,
// and entities on the Bureau of Export Administration Entity List or
// involved with missile technology or nuclear, chemical or biological weapons)
//-----------------------------------------------------------------------------
// © 1982 - 2020 Microsoft Corporation.All rights reserved.
//-----------------------------------------------------------------------------

/*------------------------------------------------------------------------------
 * System Directives - .NET Framework Assemblies - begins with System - here
 * grayed are not in use, compiler remove them at build run.
 *------------------------------------------------------------------------------
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Runtime.InteropServices;

// Set here other Directives/namespaces or namespaces with static class
// from other Csharp Files .cs in Project-Solution.
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

/*-----------------------------------------------------------------------------
 * TIPPLINTIP - want use internals from a Assembly lock / NOT visible! 
 * with keyword internal by class, method, 
 * ----------------------------------------------------------------------------
 * property set following Attribute in AssemblyInfo.cs file:
 * [assembly: InternalsVisibleTo("assemblyname without .dll")]
 * ----------------------------------------------------------------------------
 */





//-----------------------------------------------------------------------------
// Visual.Function.Library.dll written C, for .NET and Visual C#
//
//-----------------------------------------------------------------------------
// Use inside the CharSet = CharSet.Unicode, while Visual C# make by .Auto
// convert to .Ansi, NOTE! at Windows Operation System Team in next Windows OS
// use only unicode! - unicode with UTF8, UTF16, UTF32 (only algor.) -
// Common Language Runtime IN/OUT works UTF16 and sign @ as UTF16
// @ for formatting by urls: \\..\\..\\
// @"\server\...\...\"
//-----------------------------------------------------------------------------
// \ backward slash - Windows System
// / forward slash - HTML, Websites
//
//-----------------------------------------------------------------------------
namespace Visual.Function.Library
{

    /// <summary>
    /// Use native Visual Function Library.dll
    /// </summary>
    /// <!-- Author Tipplin -->
    /// Visual C#:
    /// [DllImport("VFL.dll", EntryPoint = "vgfVFLMsgBox", SetLastError = true, 
    /// CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    /// 
    /// same in C++ by switch /clr - support common language runtime .NET
    /// then without C++ Headerfiles.
    /// 
    /// Visual C++.NET:
    /// [DllImport("VFL.dll", EntryPoint = "vgfVFLMsgBox", SetLastError::true, 
    /// CharSet::CharSet.Unicode, CallingConvention::CallingConvention.StdCall)]
    /// 
    /// 
    /// Set CharSet as Unicode everytime by Visual C#, 
    /// Visual C# change .Auto to .Ansi everytime internal.
    /// next Windows is only unicode ! International Signs
    /// Germany, Autriche and Switzerland 
    /// 
    /// Special stupid "German Umlauts", can use UTF8/UTF16,
    /// Tipplin have create comments in markdown file, 
    /// paper from Dr. Knittel (CBM) for German Umlauts written in German and English.
    /// NOTE: Common Language Runtime works IN/OUT with UTF16.
    /// <!--Author Tipplin -->
    public static class VOSSafeNativeVisualFunctionLibrary
    {

        #region ### Visual.Function.Library Dll - our famous C Functions Library ###

        
        #endregion

        // Compiler make to reverse the DllImportAttribute
        // [DllImport("VFL.dll", EntryPoint = "VFLMsgBox", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        // reverse:
        // [DllImport("VFL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "vgfVOLMsgBox", SetLastError = true)]
        // ! don't forget!, SetLastError only for C++, C# - not for Java and Visual Basic.NET.
        // Windows 10 with GetLastError -> GetWinLastError (.NET)
        // Windows 10 new with RestoreLastError.
        //
        // For Visual C++.NET Developer the same for DllImport without Headerfiles and switch  /clr for common language runtime 
        // [DllImport("mscrt.dll", EntryPoint = "printf", SetLastError::true, CharSet::CharSet.Unicode, CallingConvention::CallingConvention.StdCall)]
        // extern static int Printf(string ^ Format, ...) 
        // Note! Microsoft Name Convention! - The first Letter must be upper ! by Functionname.
        // For all manged names, C/C++ Runtimes Functions (printf, scan, _kbhit...)
        //
        // [DllImport("VFL.dll", EntryPoint = "VFLMsgBox", SetLastError::true, CharSet::CharSet.Unicode, CallingConvention::CallingConvention.Cdecl)]
        //----------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// MessageBox from our famous Visual.Function.Library.dll written in C.
        /// </summary>
        /// <!-- Author TIPPLIN 🧑-->
        /// -------------------------------------------------------------------
        /// At next in new Project an better MessageBox as this old Style,
        /// Project "" - WPFMessageBox with many Features:
        /// -------------------------------------------------------------------
        /// WPFMessageBox: 3D Icons, Hyperlink, Clipboard, Copy, Scrollbar, 
        /// Expand WPFMessageBox to Full Window at Left Corner 
        /// Black Field click and make it greather,
        /// Timeout, set value and the WPFMessageBox 
        /// close automatic by no User Action!.
        /// -------------------------------------------------------------------
        /// (NOTE: same was in Windows Operation System 
        /// as MessageBoxTimeout Function)
        /// -------------------------------------------------------------------
        /// (NOTE: STOPPED a Thread with Thread.Sleep or 
        /// Sleep Function can write this:
        /// 
        /// Thread.Sleep(5000 * MessageBox("After OK Click, Thread continue!", 
        /// "Thread", OK, Icon...) );
        /// 
        /// * asteric as operator, so sleep the Thread 
        /// 5 seconds and than the MessageBox shows the Message.
        /// 
        /// Thread.Sleep(5000 * MethodName(parameters) );
        /// -------------------------------------------------------------------
        /// * asteric as operator, so sleep the Thread 5 seconds and 
        /// than execute the Call/Method.
        /// -------------------------------------------------------------------
        /// Many Timers in .NET Framework without any Control!
        /// 
        /// Timers Timer;
        /// Timer(interval, parameter, Call, x);
        /// The Timer execute after TimeInterval any time this Call, 
        /// don't forget the Timer.Stop!,
        /// Forget the Timer runs continue.
        /// -------------------------------------------------------------------
        /// Same in Mobile Class Vibrator as Timer, 
        /// forget Timer.Stop - Phone any time vibrate.
        /// -------------------------------------------------------------------
        /// <!-- Author TIPPO 🧑-->
        /// <param name="lpszText">set here your Text</param>
        /// <param name="lpszTitel">set here your Title</param>
        /// <param name="styles">Enumerator Styles: 
        /// Button, Icon, SetForeground, SystemModal</param>
        /// set here the Style do you want
        /// 1 - 4
        /// OK Button
        /// 1 Critical Icon
        /// 2 Exclamation Icon
        /// 3 Information Icon
        /// 4 Question Icon
        /// 5 - 8
        /// YESNO
        /// 9 - 12
        /// ABORTRETRYIGNORE
        /// 
        /// <remarks>
        /// Note!, MessageBox from System with public Flags,
        /// MessageBox is alltime in Foreground and SystemModal,
        /// so the user must be closed, 
        /// before work continue with other App/Window.
        /// AppModal you can switch to other App/Window.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("VFL.dll", EntryPoint = "VFLMsgBox", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern uint VFLMsgBox(
                                               // LPWSTR (wchar_t) must be marshalling, by LPSTR can set string directly.
                                               [MarshalAs(UnmanagedType.LPWStr)]
                                               string lpszText,
                                               // LPWSTR (wchar_t) must be marshalling, by LPSTR can set string directly.
                                               [MarshalAs(UnmanagedType.LPWStr)]
                                               string lpszTitel,
                                               // Enumerator like VB for C#, show in Method as Parameter at .point, than a intellisense Window.
                                               STYLES styles);

        /// <summary>
        /// Show MessageBox with predefined Messagetext.
        /// </summary>
        /// <param name="TextID">Set integer value 1 to 25</param>
        /// <!-- Author TIPPO -->
        /// Tippo idea set predefined Messagetext in char array, written in a C Library.
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("VFL.dll", EntryPoint = "VFLMessageBox", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern int VFLMessageBox(int TextID);





        /// <summary>
        /// Set Privilege for User
        /// </summary>
        /// <!-- Author TIPPO -->
        /// NOTE! you must have Administrators Rights !
        /// for set Privileges.
        /// <!-- Author TIPPO -->
        /// <param name="lpszPrivilegeName">Set Privilege Name</param>
        /// <param name="bEnablePrivilege">Set Enable Privileges with true/false</param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// returned successfully true/0, failure false/1
        /// </returns>
        [DllImport("VFL.dll", EntryPoint = "VFLSetUserPrivilege", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool VFLSetUserPrivilege(
                                                            [MarshalAs(UnmanagedType.LPTStr)]
                                                            string lpszPrivilegeName,
                                                            bool bEnablePrivilege);

        /// <summary>
        /// Start directly an executable File .exe
        /// </summary>
        /// <param name="AppName">Set Applicationname</param>
        /// <!-- Author TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// Use CreateProcess for executable the app
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("VFL.dll", EntryPoint = "VFLStartDirectEXE", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool VFLStartDirectEXE(
                                                        [MarshalAs(UnmanagedType.LPTStr)]
                                                        string AppName);



    } // end of class::NativeVisualFunctionLibrary


    /// <summary>
    /// 
    /// </summary>
    public static class NativeLicenseFunction
    {
        

        /// <summary>
        /// Verify the License File
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Set constant License Text Entry
        /// Copyright © 2019 by VGF-KernelTeam and Christian 'TIPPO' Kurs.
        /// if NOT in our License File, terminate!
        /// <!-- Author Tipplin -->
        /// <param name="LicFile">Set License File Name</param>
        /// <remarks>
        /// make great License System for optimal save!
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("VLL.dll", EntryPoint = "VLLLicVerifyLicFile", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool VLLLicVerifyLicFile(
                                                         [MarshalAs(UnmanagedType.LPWStr)]
                                                         string LicFile
                                                         );








    } // END::OF::CLASS::NativeLicenseFunction

} // END::OF::NAMESPACES::Visual.Function.Library

//*****************************************************************************
//***************** END OF FILE NativeVisualFunctionLibrary.cs ****************
//*****************************************************************************
