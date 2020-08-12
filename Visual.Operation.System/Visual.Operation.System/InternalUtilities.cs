/*********************************************************************************
*	Copyright © 2019 by VGF-KernelTeam and Christian 🧑'TIPPO'🧑 Kurs.
*			All Rights Reserved.
*
*   ▶▶ Parts of Copyright by Microsoft Corporation with Permission.
*   ➡ Many Thanks for this Help !
* 
*********************************************************************************/
/*
    This software is the confidential and proprietary information of
    VGF-KernelTeam - ("Confidential Information").  You shall not
    disclose such Confidential Information and shall use it only in
    accordance with the terms of the License Agreement you entered into
    with VGF-KernelTeam.

    VGF-KERNELTEAM MAKES NO REPRESENTATIONS OR WARRANTIES ABOUT THE SUITABILITY OF
    THE SOFTWARE, EITHER EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
    IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
    PURPOSE, OR NON-INFRINGEMENT.

    VGF-KERNELTEAM SHALL NOT BE LIABLE FOR ANY DAMAGES
    SUFFERED BY LICENSEE AS A RESULT OF USING, MODIFYING OR
    DISTRIBUTING THIS SOFTWARE OR ITS DERIVATIVES.

    Copyright_Version_1.0_BETA

    This file is the same as x that comes with y,
    except that the has been changed so that it is compilable
    under more than just
*/

/**************************************************************************************************
    MAC, macOS, watchOS, tvOS is a registered trademark of Apple Computer, Inc. 
    ! NOTE ! iOS is a registered trademark of Cisco Corporation.
    Intel is a registered trademark of Intel Corporation. 

    Active Desktop, ActiveX, Authenticode, BackOffice, FoxPro, FrontPage, 
    Visual Studio, Jscript, Microsoft, Microsoft Press, MSDN, MS-DOS, MSN, 
    Outlook, PivotTable, PowerPoint, Visual Basic, Visual C++, Visual FoxPro, 
    Visual InterDev, Visual J++, J#, Visual Studio, Win32, Windows, 
    and Windows NT are either registered trademarks or 
    trademarks of Microsoft Corporation in the United States and/or other countries.
    -----------------------------------------------------------------------------------------------
    🚩 Microsoft Export Restrictions 🚩 :
    -----------------------------------------------------------------------------------------------
    🚧 ! ATTENTION ! 🚧 write for Export 🚧 ! 
    This software is subject to the U.S. Export Administration Regulations and 
    other U.S. law, and may not be exported or re-exported to certain countries 
    ( Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) or 
    to persons or entities prohibited from receiving U.S. exports 
    (including Denied Parties, Specially Designated Nationals, 
    and entities on the Bureau of Export Administration Entity List or 
    involved with missile technology or nuclear, chemical or biological weapons).

    Copyright © 1982 - 2019 Microsoft Corporation. All rights reserved.

****************************************************************************************************/

//-----------------------------------------------------------------------------
// Gecko: a PTB Time Clock App - https://uhr.ptb.de
// PTB Uhr show you current Time with deviation 1 leap second and deviation 
// local time with deviation milliseconds +- unsave.
// Leap Second end of 2018 - 31.01.2018/01.01.2019
//-----------------------------------------------------------------------------
// USA - Microsoft have Information about Leap Second on:
// 05:00:59 old -> 05::00:60 -> 05:01:00
//-----------------------------------------------------------------------------

/* 
 * All System or Windows Directives here:
 * 
 * 
*/
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.InteropServices;


using Microsoft.Win32;

using System.Resources;

//-----------------------------------------------------------------------------
// No Directive, is a namespace in this Project-Soultion in a other .cs file
// in Visual.Operation.System all Classes and Methods static,
// but NOT the namespace only set so!
// No Directive, is a namespace in this Project-Solution in a other .cs file
// So we set the same namespace and static class
//------------------------------------------------------------------------------

using Visual.Operation.System.Native;

// use here same Windows Operation System - Constants, Enumerators, Structs...
using static Visual.Operation.System.Native.NativeMethods;

// use here same Windows Operation System Functions
using static Visual.Operation.System.Native.UnsafeNativeMethods;

// use here C/C++ Runtimes Library Functions
using static Visual.Operation.System.Native.NativeRuntimeMethods;


//
using static Visual.Operation.System.Base.VOSInternalBase;

//
using Visual.Operation.System.Properties;

// use here our Style for MessageBox
// For new Project 'Modern WPFMessageBox' use 3d Icons, hyperlink, copy button, 
// clipboard,
// timeout by no user action (close automatic), 
// left top corner field - click the Modern WPFMessageBox full screen
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;


//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
//🧑
//
//-----------------------------------------------------------------------------
namespace Visual.Operation.System.Internal.InternalUtilities
{

    /// <summary>
    /// Battery Statuc Info now!
    /// </summary>
    public class BatteryStatusInfo
    {

        #region ### Class PowerStatus ###

        // /***
        // * You comment block in Visual C# begins with forward slash and three asterics, that's allowed in C#.
        // * NOT allowed ! /** like Java, Javascript
        // *// NOT allowed !
        // * 
        // * 
        // */
        // NOTE: without accessmodi that means public, protected, internal, internal protected...
        // all are private is the standard in Visual C#.
        // ATTENTION ! private have an protection of degree, no access outside.
        //




        /*
         * Use StringBuilder for Buffers, C++ Buffers:
         * StringBuilder without set minium and maxium or value ()
         * var stringBuilder = new StringBuilder(255, 8096);
         * var stringBuilder = new StringBuilder(255);
         * standard value internal is 16 chars fix.
         * internal const int DefaultCapacity = 16;
         * 
         * var stringBuilder = new StringBuilder(259);
         * 
         * // Dir 260 chars allowed, but set 260 -1 is better.
         * if (Win32Native.GetSystemDirectory(stringBuilder, 259) == 0)
         * {
         * }
         * 
         * var stringBuilder = new StringBuilder(256);
         * int bufferSize = 256;
         * 
         * //--------------------------------------------- sizeof bufferSize
         * if (Win32Native.GetComputerName(stringBuilder, ref bufferSize) == 0)
         * {
         *   
         * }
         * 
         * Win32Native.SYSTEM_INFO lpSystemInfo = default(Win32Native.SYSTEM_INFO);
         * 
         * Win32Native.GetSystemInfo(ref lpSystemInfo);
         * 
         * return lpSystemInfo.dwPageSize;
         * 
         * 
         * 
         * 
         */






        /// <summary>
        /// Instance to Class PowerStatus BatteryStatusInfo, while the Class is not written static.
        /// now is on Stack than!
        /// <!-- Author Tippo -->
        /// Class PowerStatus from namespace System.Windows.Forms
        /// in this namespace are 300 Classes for use!
        /// Class Application - Application.AllowQuit true/false allowed or not allowed user to close the Application.
        /// means distributed work on CPU kernels, take thread on CPUKernel 2 with I/O Works, 
        /// if they runs, your can set false so he can not close Application.
        /// Class Webbrowser create your own Webbrowser or Allows the user to navigate to web pages within a form.
        /// Classes all Controls
        /// Class OSFeatures query
        /// Class Screen query Bits per Pixel, Devicename
        /// 
        /// 
        /// StructFormat/Structs: 
        /// CharSet.Auto
        /// Make sure and set not .Auto while C# Compiler change to .Ansi not to .unicode
        /// 
        /// <!-- Author Tippo -->
        /// 
        /// <remarks>
        /// see here Lambda operator for short names
        /// </remarks>
        /// 
        /// </summary>
        internal PowerStatus ps;

        /// <summary>
        /// Battery Charge Status as string
        /// </summary>
        internal string BattCS => ps.BatteryChargeStatus.ToString();

        /// <summary>
        /// Battery Full Life Time now ?
        /// </summary>
        internal int BattLife => ps.BatteryFullLifetime;

        /// <summary>
        /// Battery Life loading Accu in Percent
        /// </summary>
        internal float BattLifeP => ps.BatteryLifePercent;

        /// <summary>
        /// Battery Life Remaining Time in Seconds
        /// </summary>
        internal int BattLifeR => ps.BatteryLifeRemaining;

        /// <summary>
        /// Actual Power Status for System Energy
        /// </summary>
        internal string BattPLS => ps.PowerLineStatus.ToString();

        #endregion




    } // end of Class::BatteryStatusInfo





    /// <summary>
    /// class InternalUtilities most at Windows Operation System
    /// </summary>
    public static class VOSInternalUtilities
    {

        #region ### Global Settings: variables, constants ###

        // Global ! for all Methods....

        /// <summary>
        /// Is Windows Operation System OLD ?
        /// </summary>
        internal static bool m_IsOldOS;

        

        //*********************************************************************
        // for short sign, we set lambda operator
        // New ! lambda operator => to Class Enviroment.Property MachineName
        // internal static string Name => Environment.MachineName;
        //*********************************************************************
        #region ### Information of Enviroment ### 

        /// <summary>
        /// Get the Name of current Computer
        /// </summary>
        internal static string Name => Environment.MachineName;
        
        /// <summary>
        /// Get the Name of current User
        /// </summary>
        internal static string User => Environment.UserName;

        /// <summary>
        /// Is current Operation System 64BIT ?
        /// </summary>
        internal static bool X64 => Environment.Is64BitOperatingSystem;

        /// <summary>
        /// Is current Process 64BIT ?
        /// </summary>
        internal static bool X64Process => Environment.Is64BitProcess;

        /// <summary>
        /// Get System Directory as string
        /// </summary>
        internal static string SysDir => Environment.SystemDirectory;


        #endregion ### END Information of Enviroment ### 


        #region ### Struct MemoryStatusex with short name, use Lambda Operator => ###

        // use Struct MEMORYSTATUSEX, use instancevariable msx

        /// <summary>
        /// Available Physical Memory at System
        /// </summary>
        internal static ulong AvailPhys => msx.availPhys;

        /// <summary>
        /// Total Physical Memory Value at System
        /// </summary>
        internal static ulong TotalPhys => msx.totalPhys;
        
        /// <summary>
        /// Total Page File Value at System
        /// </summary>
        internal static ulong TotalPage => msx.totalPageFile;
        
        /// <summary>
        /// Total Virtual Memory Value at System
        /// </summary>
        internal static ulong TotalVir => msx.totalVirtual;
        
        /// <summary>
        /// MemoryLoad in percent % as integer value
        /// </summary>
        internal static int MemPers => msx.memoryLoad;


        #endregion ### END Struct MemoryStatusex with short name, use Lambda Operator => ###


        #region ### Class SystemInformation from namespace System.Windows.Forms ###

        /// <summary>
        /// Boot Mode at Windows Operation System, how started with StartModus
        /// Windows 10 Operation System without any Errors, is BootModeStatus => normal
        /// </summary>
        internal static string OSBootMode => SystemInformation.BootMode.ToString();

        /// <summary>
        /// Count of Screens of Desktop
        /// </summary>
        internal static int Mode => SystemInformation.MonitorCount;

        /// <summary>
        /// Counts Mouse Buttons
        /// </summary>
        internal static int MouseButton => SystemInformation.MouseButtons;

        /// <summary>
        /// Mouse have Wheel ?
        /// </summary>
        internal static bool MBWheel => SystemInformation.MouseWheelPresent;

        /// <summary>
        /// Is Network Connection avaiblable ?
        /// </summary>
        internal static bool NetConnect => SystemInformation.Network;

        /// <summary>
        /// Have Operation System a Security Manager ?
        /// </summary>
        internal static bool SecManager => SystemInformation.Secure;

        /// <summary>
        /// Process to Terminal Session Client Service ?
        /// </summary>
        internal static bool TermSerSession => SystemInformation.TerminalServerSession;



        #endregion ### END Class SystemInformation from namespace System.Windows.Forms ###


        #region ### Class Application from namespace System.Windows.Forms ###

        /*
         * Class Application have same Methods and Properties.
         * by distributed work timed i/o Operations,
         * allot to an CPU Thread, Microoft Tool:
         * CPU 0 to CPU 63 checkbox
         * !NOTE! Hand offs CPU 0, Operation System works here!
         * Threads allot to CPU 1 to CPU 63
         * So the Thread is running, but the User want close Application ?
         * to forbid the close set:
         * Application.QuitAllowed = false; // is a Property - bool -
         * The User can't close Application !.
         * Give Message to User: "The Work I/O Operation x is now running, you can't close Application... wait moment!"
         * 
         * Windows Operation System Function:
         * ==================================
         * SetAffinityMask(Thread, Mask);
         * SetAffinityMask(currentThread, 0x2);
         * Start Thread on CPU 2.
         * Turbo Mode for rapid work is 3.
         * 
         * Create Jobs, batch-file, powershell script, .exe,
         * Windows Operation System System Tool, command line tool:
         * Start <job name>
         * generally start jobs at afternoon/night ! for reports, backups...
         * 
         * Create powershellscript compiled as inline compilation 
         * to powershellscriptname.exe with date/Time he runs,
         * and take it in job batchfile.
         * 
         * --------------------------------------------------------------------
         * Query Properties for Language, Culture.
         * 
         * ISO Organization
         * 
         * http://www.iso.org
         * 
         * Unicode Ogranization - .NET unicode is Version 12.1.0 
         * Unicode 12.1 adds exactly one character, for a total of 137,929 characters. 
         * Take in your Project only unicode !
         * Windows Operation System in unicode / ansi written,
         * Common Language Runtime written in unicode with UTF16 in/out.
         * new website
         * https://home.unicode.org/
         * 
         * 
         * !NOTE! Visual C# Compiler change CharSet.Auto to CharSet.Ansi,
         * so set CharSet.Unicode is better !.
         * 
         * Unicode Version 12.0 - 2019 - plus Handbook at Unicode Organization -
         * Windows 10 - 2020 - emoji's, katemoji's with chat symbols and symbols Unicode 12
         * 
         */


        /// <summary>
        /// Get current Culturename languagecode2 country and regioncode2
        /// </summary>
        internal static string CultName => Application.CurrentCulture.Name;

        /// <summary>
        /// Get the current Two Letter ISO Name - Germany de-DE, USA en-US, United Kingdom en-EN...
        /// </summary>
        internal static string CultTwoISOName => Application.CurrentCulture.TwoLetterISOLanguageName;

        /* 🧑
        * -----------------------------------------------------------------------
        * Get the current Three Letter ISO Name:
        * For Germany: 
        * den-WEN - Sorbish, a people in the Spreewood by Berlin.
        * -----------------------------------------------------------------------
        * Sorbish: 
        * Witami nam (Willkommen) 
        * dobre ranje (Guten Morgen)
        * 
        * ----------------------------------------------------------------------
        * Three Letter ISO Language for Dialects is Regional Dialect:
        * Tipplin make home language Boennsch - den-BON
        * ----------------------------------------------------------------------
        * 🧑
        */

        /// <summary>
        /// Get the current Three Letter ISO Name
        /// </summary>
        internal static string CultThreeISOName => Application.CurrentCulture.ThreeLetterISOLanguageName;

        /// <summary>
        /// What Fontname have the Current Culture
        /// </summary>
        internal static string CultFontName => Application.CurrentCulture.TextInfo.CultureName.ToString();




        #endregion ### END Class Application from namespace System.Windows.Forms ###





        //---------------------------------------------------------------------
        // Set here Global Struct Instances but not the Call, only Method.
        //---------------------------------------------------------------------
        #region ### Structures - Here Global in Class Head - Only Structs, No Call, only in Method ###


        /// <summary>
        /// Extended MemorystatusEX
        /// </summary>
        /// <!-- Author TIPPO 🧑 -->
        /// see, you can set all in the Classhead so this is GLOBAL for all Methods in the Class !.
        /// <!-- Author TIPPO 🧑 -->
        /// <remarks>
        /// NOTE! all Windows Functions, struct's with extension EX,
        /// are permament call by Operation System, so write Wrapper for this.
        /// Structure instance can set in Class Head,
        /// here MEMORYSTATUSEX with instancevariable msx, 
        /// everytime on HEAP with new operator
        /// internal static MEMORYSTATUSEX msx; 
        /// On STACK !
        /// </remarks>
        internal static MEMORYSTATUSEX msx = new MEMORYSTATUSEX();

        /// <summary>
        /// Class StringBuilder expand version: minimum and maximum
        /// StringBuilder(int32 min, int32 max);
        /// and more options.
        /// StringBuilder for Visual C++ Buffers!
        /// Class StringBuilder is 3000x faster as string! (internal StringBuilderCache)
        /// </summary>
        internal static StringBuilder sb = new StringBuilder(255, 1024);





        #endregion ### Structures - Here Global in Class Head - Only Structs, No Call, only in Method ###

        //---------------------------------------------------------------------
        // Class AssemblyInfo is normally not in AssemblyInfo.cs
        // have written this class in this File with 
        // more Information of Assembly.
        //--------------------------------------------------------------------

        

        //---------------------------------------------------------------------
        // Visual Studio create automtic GUID for any Assembly.
        //---------------------------------------------------------------------
        // So any Windows Operation System has GUID's in Binary File:
        // Setup.bin
        // can read with Editor, the GUID's are clear in XML Format
        // Windows XP to Windows 10.
        //---------------------------------------------------------------------
        // GUID and UUID (Apple)
        //---------------------------------------------------------------------
        internal const string VisualOperationSystemAssemblyGuid = "f94d5384-f0d5-4402-a72c-3c33cf2ad15e";

        //---------------------------------------------------------------------
        // Is for validate the current GUID from current Assembly
        //---------------------------------------------------------------------
        /// <summary>
        /// gd - instancevariable for Class Guid
        /// </summary>
        /// <!-- Author TIPPO -->
        /// general unique identify - GUID -
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// GUID's for Assembly, Operation System (Windows Vista to Windows 10),
        /// UUID's by Apple is the same.
        /// </remarks>
        internal static Guid gd = new Guid(VisualOperationSystemAssemblyGuid);


        // TOKEN_PRIVILEGES -
        internal static int ANYSIZE_ARRAY = 1;




        #endregion ### Global Settings: variables, constants ###


        #region ### Windows Operation System - Enumerators - ###


        /// <summary>
        /// Message STYLES for our MessageBox, same as System.
        /// write Enumerator the same as in Visual Basic.NET,
        /// STYLES in intellsense Window - Style.enum-member
        /// Style.OKOnlyButton | STYLES.Iconname | STYLES.SetForgroundWindow | STYLES.SystemModal
        /// </summary>
        /// <!-- Author TIPPO -->
        /// Initial enum by VB.NET as intellisense Window, 
        /// so write it for Visual C#.
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// Windows Operation System Icons in imageres.dll (all resources), shell32.dll.
        /// Zipper 7Zip open imagres.dll see under tag Resource, all resources as resourcenumber (many)
        /// under icons all Windows Icons, marked and expand to a Folder.
        /// </remarks>
        [Flags]
        internal enum STYLES : long
        {
                /// <summary>
                /// Button OK only
                /// </summary>
                OkOnly = 0,

                /// <summary>
                /// Button OK and Cancel
                /// </summary>
                OkCancel = 1,

                /// <summary>
                /// Button Abort and Retry and Ignore
                /// </summary>
                AbortRetryIgnore = 2,

                /// <summary>
                /// Button Yes and No and Cancel
                /// </summary>
                YesNoCancel = 3,

                /// <summary>
                /// Button Yes and No
                /// </summary>
                YesNo = 4,

                /// <summary>
                /// Button Retry and Cancel
                /// </summary>
                RetryCancel = 5,
        
                /// <summary>
                /// Application Icon
                /// </summary>
                Application = 32512,

                /// <summary>
                /// Critical Icon
                /// </summary>
                Critical = 32513,

                /// <summary>
                /// Question Icon 
                /// </summary>
                Question = 32514,

                /// <summary>
                /// Icon Exclamation
                /// </summary>
                Exclamation = 32515,

                /// <summary>
                /// Icon Information
                /// </summary>
                Information = 32516,

                /// <summary>
                /// Icon Windows Operation System Logo
                /// </summary>
                /// 
                Winlogo = 32517,

                /// <summary>
                /// Icon Shield green, yellow, red
                /// means the Security Shield
                /// </summary>
                Shield = 32518,

                /// <summary>
                /// Flag AppModal for this Window,
                /// can switch to other App/Window.
                /// L is signed 64BIT values,
                /// if write l, the compiler says oh! 
                /// can make trouble with 1 confusion, better upper L.
                /// ul is unsigned integer 
                /// </summary>
                AppModal = 0x00000000L,
                           
                /// <summary>
                /// Flag SystemModal for this Window,
                /// User must bes close the Window, before he continue the Work,
                /// NO switch to other App's.
                /// </summary>
                SystemModal = 0x00001000L,

                /// <summary>
                /// Flag TaskModal 
                /// </summary>
                TaskModal = 0x00002000L,

                /// <summary>
                /// Flag SetForeGround,
                /// The Window is Foreground everytime.
                /// </summary>
                MsgBoxSetForeground = 0x00010000L
        }

        /// <summary>
        /// Enumerator form MessageBox Results
        /// </summary>
        internal enum MESSAGE_BOX_RESULT:uint
        {
            /// <summary>
            /// returned OK = 1
            /// </summary>
            OK = 1,
            /// <summary>
            /// returned NO = 7
            /// </summary>
            NO = 7,
            /// <summary>
            /// returned YES = 6
            /// </summary>
            YES = 6,
            /// <summary>
            /// returned IGNORE = 5
            /// </summary>
            IGNORE = 5,
            /// <summary>
            /// returned RETRY = 4
            /// </summary>
            RETRY = 4,
            /// <summary>
            /// returned ABORT = 3
            /// </summary>
            ABORT = 3,
            /// <summary>
            /// returned TRYAGAIN = 10
            /// </summary>
            TRYAGAIN = 10

        }
        









        #endregion  ### Windows Operation System - Enumerators - ###

        #region ### Windows Operation System - Structures - ###

        /// <summary>
        /// Structure STARTUPINFO
        /// </summary>
        /// <!-- Author TIPPO -->
        /// insert at 21.09.2018 11:00
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// 
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct STARTUPINFO
        {

            internal Int32 cb;

            internal string lpReserved;

            internal string lpDesktop;

            internal string lpTitle;

            internal Int32 dwX;

            internal Int32 dwY;

            internal Int32 dwXSize;

            internal Int32 dwYSize;

            internal Int32 dwXCountChars;

            internal Int32 dwYCountChars;

            internal Int32 dwFillAttribute;

            internal Int32 dwFlags;

            internal Int16 wShowWindow;

            internal Int16 cbReserved2;

            internal IntPtr lpReserved2;

            internal IntPtr hStdInput;

            internal IntPtr hStdOutput;

            internal IntPtr hStdError;

        }

        /// <summary>
        /// Struct PROCESS_INFORMATION
        /// </summary>
        /// <!-- Author TIPPO -->
        /// insert at 21.09.2018 11:00
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// 
        /// </remarks>
        [StructLayout(LayoutKind.Sequential)]
        internal struct PROCESS_INFORMATION
        {

            public IntPtr hProcess;

            public IntPtr hThread;

            public int dwProcessId;

            public int dwThreadId;

        }


        #endregion ### Windows Operation System - Structures - ###




        /// <summary>
        /// Get the Name of Assembly
        /// </summary>
        /// <!-- Author TIPPO -->
        /// use Class AssemblyInfo, what not normally in File AssemblyInfo.cs
        /// <!-- Author TIPPO-->
        /// <returns>
        /// 
        /// </returns>
        public static string VOSGetAssemblyName()
        {
            // ai is the instance variable for Class AssemblyInfo
            return vos.AsmFQName;
        }

        /// <summary>
        /// Get the Copyright Info of Assembly
        /// </summary>
        /// <!-- Author TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <returns>
        /// 
        /// </returns>
        public static string VOSGetCopyrightInfo()
        {
            // ai is the instance variable for Class AssemblyInfo
            return vos.Copyright;
        }

        /// <summary>
        /// Get the Assembly Description
        /// </summary>
        /// <!-- Author TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <returns>
        /// 
        /// </returns>
        public static string VOSGetAssemblyDescription()
        {
            // ai is the instance variable for Class AssemblyInfo
            return vos.Description;
        }

        /// <summary>
        /// Validate the current Assembly GUID
        /// Assembly GUID in this now, stands in AssemblyInfo.cs and Class AssemblyInfo
        /// </summary>
        /// <!-- Author TIPPO -->
        /// GUID's for all Windows Operation Systems !
        /// Setup.bin - is setup file for Windows - is compiled,
        /// but have XML block with GUID's, read with Editor.
        /// Windows XP to Windows 10
        /// GUID - Apple UUID
        /// 
        /// <!-- Author TIPPO -->
        /// <returns>
        /// 
        /// </returns>
        internal static bool VOSValidateAssemblyGUID()
        { 

            // ai is the instance variable for Class AssemblyInfo
            if (vos.AssGUID == VisualOperationSystemAssemblyGuid)
            {
                return true;
            }
            else
            {
                vosmessage = "The AssemblyGUID is NOT guilty !\n";
                vosmessage += "Terninate now!.\n";

                VFLMsgBox(vosmessage, "Check Assembly GUID", STYLES.OkCancel | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

                // terminate this Assembly as Thread but NOT the Process (App).
                // set on System Errorcode 12 - The access code is invalid.
                NRMExit(EXIT_CODES.ERROR_INVALID_ACCESS);
                    return false;
            }

        } // end of Method::VOSValidateAssemblyGUID



        /// <summary>
        /// Is Older Operation System on current Computer
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        public static bool VOSIsOldOperationSystem()
        {
            // 
            // see the new Microsoft Code Convention ( () ), better Code Tuning!
            // Compile goes in first Clamatur validate and goes next.
            return m_IsOldOS = ( (Environment.OSVersion.Version.Major < 6) || (Environment.OSVersion.Version.Minor < 3) );
        }


        /// <summary>
        /// Get the Available Physical Memory on this Computer 
        /// </summary>
        public static ulong GetAvailablePhysicalMemory
        {
            /*
             * Instance for struct MEMORYSTATUSEX in Class-Head as Global for all other Classes/Methods.
             */

            // property get
            get
            {
                //Refresh();
                if (!m_IsOldOS)
                {
                    return
                        msx.availPhys;
                }
                return msx.availPhys; 
            }

        }

        /// <summary>
        /// Visual Operation System Beep
        /// </summary>
        /// <returns></returns>
        public static bool VOSFunction001()
        {
            try
            {
                return Beep(15000, 5000);
            }
            catch(Win32Exception ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // end of Method::VOSFunction001

        /// <summary>
        /// Call Operation System Function
        /// </summary>
        /// <param name="MethodID"></param>
        /// <returns></returns>
        public static bool VOSFunction002(int MethodID)
        {
            bool p = false;

            try
            {
                switch (MethodID)
                {
                    case 1:
                        Beep(15000, 5000);
                        break;
                    case 2:
                        CheckTokenMembership(GetCurrentProcess(), null, p);
                        break;
                    default:
                        VFLMsgBox("Function is not implemented !.", "Exception at Method::VOSFunction003", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                        break;
                }

            }
            catch(SystemException ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VOSFunction003", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

            return true;

        } // end of Method::VOSFunction002

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ErrorCode"></param>
        /// <returns></returns>
        public static string VOSGetMessage(uint ErrorCode)
        {
            try
            {

                /*
                 * see here instance for StringBuilder expand
                 * is more flexible as others and 
                 * is 3000x faster as string by sorted methods.
                 * see more Information at:
                 * For Developer come from C++:
                 * ----------------------------
                 * use StringBuilder for Buffers
                 * internal const int Buffer1 = 255; 
                 * var sb = new StringBuilder(Buffer1);
                 * 
                 */
                var sb = new StringBuilder(255, 2048);

                // FormatMessage use here, but is now in .NET FX defined.
                FormatMessage(  
                                // dwFlags
                                FORMAT_MESSAGE_FROM_SYSTEM,
                                IntPtr.Zero, 
                                // 
                                ErrorCode, 
                                0, 
                                // for Buffer, general you use StringBuffer for C/C++ Buffers
                                sb,
                                // set sb.Capacity for maxium Chars in StringBuffer here 2048 chars,
                                // StringBuffer expand automatic to maxium!,
                                // single value and the string greather as the limit he cut the string!
                                sb.Capacity,
                                IntPtr.Zero);

                // 1.) StringBuilder (sb) is Object, must be convert to string.
                // 2.) convert with string.Format({0}, sb);
                return sb.ToString();
            }
            catch(SystemException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return string.Format("Message for Exception: {0}", ex.Message);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin-->
        /// <param name="Methodname"></param>
        /// <remarks>
        /// // Generate an error
        /// if(!Methodname(NULL))
        /// {
        ///     VOSErrorExit("Methodname");
        /// }
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static string VOSErrorExit(string Methodname)
        {

            
            uint dw = GetLastError();

            // FormatMessage use here, but is now in .NET FX defined.
            FormatMessage(
                            // dwFlags
                            FORMAT_MESSAGE_FROM_SYSTEM,
                            IntPtr.Zero,
                            // 
                            dw,
                            0,
                            // for Buffer, general you use StringBuffer for C/C++ Buffers
                            sb,
                            // set sb.Capacity for maxium Chars in StringBuffer here 2048 chars,
                            // StringBuffer expand automatic to maxium!,
                            // single value and the string greather as the limit he cut the string!
                            sb.Capacity,
                            IntPtr.Zero);

            vosmessage = "%s failed with error %d: %s" + Methodname + dw + sb.ToString();
            VFLMsgBox(vosmessage, "Method Error", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Messagetext"></param>
        /// <param name="appAction"></param>
        /// <returns></returns>
        public static void VOSApplicationExit(string Messagetext, int appAction)
        {

            

            switch(appAction)
            {
                

                case (int)ApplicationAction.Information:
                    vosmessage = Messagetext;
                    VFLMsgBox(vosmessage, "Application Exit Message Info ", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    NRMCExit();
                    break;
                case (int)ApplicationAction.Warning:
                    vosmessage = Messagetext;
                    VFLMsgBox(vosmessage, "Application Exit Message Warning", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    NRMCExit();
                    break;
                case (int)ApplicationAction.Critical:
                    vosmessage = Messagetext;
                    VFLMsgBox(vosmessage, "Application Exit Message Critical", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    NRMCExit();
                    break;
                case (int)ApplicationAction.FataleCritical:
                    vosmessage = Messagetext;
                    VFLMsgBox(vosmessage, "Application Exit Message Fatal Critical", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    NRMCExit();
                    break;
                default:
                    vosmessage = "unknown AppAction";
                    VFLMsgBox(vosmessage, "Application Exit Message", STYLES.OkOnly | STYLES.Exclamation  | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    NRMCExit();
                    break;

            }


        }





        /// <summary>
        /// testing your Loudspeaker on Computer with Beep: Frequence and duration
        /// </summary>
        public static void VOSTestingSpeakerWithBeep()
        {
            for (int i = 100; i <= 20000; i++)
            {
                Beep(i, 5000);
            }
        }

        /// <summary>
        /// Flash a Window Caption/Title
        /// </summary>
        /// <param name="WindowHandle">The handle to the window to flash</param>
        /// <returns>whether or not the window needed flashing</returns>
        public static bool VOSFlashWindowCaption(IntPtr WindowHandle)
        {
            NativeMethods.FLASHWINFO pfwi = new NativeMethods.FLASHWINFO();

            pfwi.cbSize = Convert.ToUInt32(Marshal.SizeOf(pfwi));
            pfwi.WindowHandle = WindowHandle;

            pfwi.dwFlags = (uint)FlashWindow.FLASHW_CAPTION;
            pfwi.uCount = UInt32.MaxValue;
            pfwi.dwTimeout = 0;

            return FlashWindowEx(pfwi);

        } // end of Method::VOSFlashWindow


        /// <summary>
        /// Flash a Window Caption/Title
        /// </summary>
        /// <param name="WindowHandle">The handle to the window to flash</param>
        /// <returns>whether or not the window needed flashing</returns>
        public static bool VOSFlashWindowTaskBar(IntPtr WindowHandle)
        {
            var pfwi = new FLASHWINFO();

            pfwi.cbSize = Convert.ToUInt32(Marshal.SizeOf(pfwi));
            pfwi.WindowHandle = WindowHandle;

            pfwi.dwFlags = (uint)FlashWindow.FLASHW_TRAY;
            pfwi.uCount = UInt32.MaxValue;
            pfwi.dwTimeout = 0;

            return FlashWindowEx(pfwi);

        } // end of Method::VOSFlashWindow

        /// <summary>
        /// Flash a Window Caption/Title
        /// </summary>
        /// <param name="WindowHandle">The handle to the window to flash</param>
        /// <returns>whether or not the window needed flashing</returns>
        public static bool VOSFlashWindowAll(IntPtr WindowHandle)
        {
            var pfwi = new FLASHWINFO();

            pfwi.cbSize = Convert.ToUInt32(Marshal.SizeOf(pfwi));
            pfwi.WindowHandle = WindowHandle;

            pfwi.dwFlags = (uint)FlashWindow.FLASHW_ALL;
            pfwi.uCount = UInt32.MaxValue;
            pfwi.dwTimeout = 0;

            return FlashWindowEx(pfwi);

        } // end of Method::VOSFlashWindow

        /// <summary>
        /// Flash a Window Caption/Title
        /// </summary>
        /// <param name="WindowHandle">The handle to the window to flash</param>
        /// <returns>whether or not the window needed flashing</returns>
        public static bool VOSFlashWindowSTOP(IntPtr WindowHandle)
        {
            var pfwi = new FLASHWINFO();

            pfwi.cbSize = Convert.ToUInt32(Marshal.SizeOf(pfwi));
            pfwi.WindowHandle = WindowHandle;

            pfwi.dwFlags = (uint)FlashWindow.FLASHW_STOP;
            pfwi.uCount = UInt32.MaxValue;
            pfwi.dwTimeout = 0;

            return FlashWindowEx(pfwi);

        } // end of Method::VOSFlashWindow

        /// <summary>
        /// Error Exit - Function
        /// </summary>
        /// <param name="FunctionName">Set FunctionName at Error</param>
        /// <remarks>
        /// Format a readable error message, display a message box, 
        /// and exit from the application.
        /// </remarks>
        public static void VOSFunctionErrorExit(string FunctionName)
        {
            StringBuilder sb = new StringBuilder(255, 4096);

            uint dw = GetLastError();

            FormatMessage(
                            FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_IGNORE_INSERTS,
                            IntPtr.Zero,
                            dw,
                            0,
                            sb,
                            sb.Capacity, 
                            IntPtr.Zero);

            vosmessage = "The Function is invalid !\n";
            vosmessage += "Terminate the Process !\n";

            string Title = string.Format("{0}", FunctionName);

            // Method from Visual Function Library.dll
            VFLMsgBox(vosmessage, Title, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

            // MS Runtime Method
            NRMExit(EXIT_CODES.ERROR_FUNCTION_NOT_CALLED);

        } // end of Method::VOSErrorExit

        /// <summary>
        /// Shutdown the Windows System for Upgrade a Application as planned.
        /// </summary>
        /// <!-- Author TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// Windows shutdown, for install upgrade and reboot, start the App new.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static bool VOSShutdownSystemForAppUpgradePlanned()
        {
            try
            {
                // Windows Operation System Function for Shutdown, close all running Processes, 
                // set Reasons for Applcation, we want make upgrade is planned !
                // after upgrad/update he reboot system.
                ExitWindowsEx(EWX_SHUTDOWN_FLAGS.EWX_SHUTDOWN | EWX_SHUTDOWN_FLAGS.EWX_REBOOT | EWX_SHUTDOWN_FLAGS.EWX_FORCEIFHUNG, SHTDN_REASON_CODES.SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_CODES.SHTDN_REASON_MINOR_UPGRADE | SHTDN_REASON_CODES.SHTDN_REASON_FLAG_PLANNED);
                return true;
            }
            catch(Win32Exception ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // end of Method::VOSShutdownSystemForAppUpgradePlanned

        /// <summary>
        /// Throw a Exception Code with HRESULT Code
        /// </summary>
        /// <param name="ExceptionCode"></param>
        /// <returns></returns>
        public static bool VOSThrowExceptionCode(int ExceptionCode)
        {
            try
            {
                Marshal.ThrowExceptionForHR(ExceptionCode);
                return true;
            }
            catch(SystemException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // end of Method::VOLThrowExceptionCode


        /// <summary>
        /// Get last Dll Error Code
        /// </summary>
        /// <!-- Author TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// If your set in [DLLImportAttribute] SetLastError = true,
        /// by unmanaged Dll Methods.
        /// </remarks>
        /// <returns>
        /// so he returned the ErrorCode.
        /// </returns>
        public static int VOSGetLastDLLErrorCode()
        {

            try
            {
                return WinLastError;
            }
            catch (SystemException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                // Visual C++ Runtime Function
                return NRMExit(EXIT_CODES.ERROR_INVALID_FUNCTION);
            }

        } // end of Method::VOLGetLastDLLErrorCode


        /// <devdoc>
        /// Please use this "approved" method to compare file names.
        /// </devdoc>
        public static bool VOSIsSamePath(string file1, string file2)
        {
            if (file1 == null || file1.Length == 0)
            {
                return (file2 == null || file2.Length == 0);
            }

            

            try
            {
                Uri uri1 = null;
                Uri uri2 = null;

                if (!Uri.TryCreate(file1, UriKind.Absolute, out uri1) || !Uri.TryCreate(file2, UriKind.Absolute, out uri2))
                {
                    return false;
                }

                if (uri1 != null && uri1.IsFile && uri2 != null && uri2.IsFile)
                {
                    return 0 == String.Compare(uri1.LocalPath, uri2.LocalPath, StringComparison.OrdinalIgnoreCase);
                }

                return file1 == file2;
            }
            catch (UriFormatException e)
            {
                Trace.WriteLine("Exception " + e.Message);
            }

            return false;
        }

        /// <summary>
        /// Test siren
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        public static bool VOSBeeps()
        {
            try
            {
                var random = new Random();

                for (int i = 0; i < 10000; i++)
                {
                    Beep(random.Next(20000), 100);
                    
                }
            }
            catch(SystemException ex)
            {
                VFLMsgBox(ex.Message, ex.TargetSite.ToString(), STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Get Computername DNS Hostname
        /// </summary>
        /// <returns></returns>
        public static string VOSGetComputerNameDNSHostName()
        {
            
            
            try
            { 
                if (GetComputerNameEx(COMPUTER_NAME_FORMAT.ComputerNameDnsHostname, sb, sb.Capacity) == 0)
                {
                    // StringBuilder is an Object, so we must convert to string with instancevariable sb.
                    // alternate with string.format("{0}", sb)
                    return sb.ToString();
                }
               
            }
            catch(Win32Exception ex)
            {
                // MessageBox from Visual.Function.Library.dll written in C.
                // STYLES is an Enumerator like VB, VB.NET with intellsense Window.
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return ex.Message;
            }

           return sb.ToString();
        }

        /// <summary>
        /// Show Windows Password Tresor
        /// </summary>
        /// <!-- Author Tipplin -->
        /// at command line input netplwiz, at Windows Web Password Tresor all Web Providers.
        /// <!-- Author Tipplin-->
        /// <remarks>
        /// show first Network Policy Wizard, go to tab extended see managed Password
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFShowWindowsWebPasswordTresor()
        {
            try
            {
                // first set directly, via point Resources in Project-Solution the same
                // all .exe as File-Resouce
                // here Netplwiz.exe - Network Policy Wizard
                // Option avanded
                Process.Start("netplwiz");
            }
            catch(SystemException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkCancel | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                // if Methode call fail, terminate with Exit_Code.
                NativeRuntimeMethods.NRMExit(EXIT_CODES.ERROR_BAD_ARGUMENTS);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Call with Commandline Control (System Control)
        /// </summary>
        /// <returns></returns>
        public static bool VGFCallCommandLineAndCallControl()
        {
            try
            {
                // Create Process and Start the given .exe with/without Arguments
                // her the command line console and the system tool Control is system control
                // for all .exe app's
                // call Webbrowser.exe and Website (argument) directly !
                //
                Process.Start(@"C:\Windows\System32\cmd.exe", "Control");
            }
            catch (SystemException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkCancel | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                // if Methode call fail, terminate with Exit_Code.
                NativeRuntimeMethods.NRMExit(EXIT_CODES.ERROR_BAD_ARGUMENTS);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFDirectlyWebsite(string Website)
        {
            try
            {
                // Create Process and Start the given .exe with/without Arguments
                // her the command line console and the system tool Control is system control
                // for all .exe app's
                // call Webbrowser.exe and Website (argument) directly !
                //
                Process.Start("microsoft-edge:"+ Website);
            }
            catch (SystemException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkCancel | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                // if Methode call fail, terminate with Exit_Code.
                NativeRuntimeMethods.NRMExit(EXIT_CODES.ERROR_BAD_ARGUMENTS);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string VGFGetVisualStudioVersionInfo()
        {
            /* Visual Studio 2019 V16.1.6 FileVersion - 16.1.29102.190 built by: D16.1"
             * VALUE "CompanyName",       "Microsoft Corporation"
             * VALUE "FileDescription",   "Microsoft Visual Studio 2019"
             * VALUE "FileVersion",       "16.1.29102.190 built by: D16.1"
             * VALUE "InternalName",      "devenv.exe"
             * VALUE "LegalCopyright",    "© Microsoft Corporation. All rights reserved."
             * VALUE "OriginalFilename",  "devenv.exe"
             * VALUE "ProductName",       "Microsoft® Visual Studio®"
             * VALUE "ProductVersion",    "16.1.29102.190"
             * 
            */
            string VSVersionInfo;

            /*
             * "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe"
             */



            FileVersionInfo.GetVersionInfo(@"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe");
            FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(@"C:\Program Files(x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe");


            // Print the file name and version number.
            VSVersionInfo = "File: " + myFileVersionInfo.FileDescription + '\n' + "Version number: " + myFileVersionInfo.FileVersion;
            return VSVersionInfo;
        }

    





    // Gibt ein Zeichenfolgenarray mit den Namen der logischen Laufwerke des aktuellen Computers zurück.
    // Ein Array von Zeichenfolgen, in dem jedes Element den Namen eines logischen Laufwerks enthält.
    // Wenn z. B. die Festplatte das erste logische Laufwerk eines Computers ist, lautet das erste zurückgegebene Element "C:\".
    // Ein E/A-Fehler tritt auf.
    // Der Aufrufer verfügt nicht über die erforderlichen Berechtigungen.


    /// <summary>
    /// Get Logical Drives
    /// </summary>
    /// <returns></returns>
    public static string[] VGFGetLogicalDrives()
        {
            
            int logicalDrives = GetLogicalDrives();
            if (logicalDrives == 0)
            {
                VFLMsgBox("GetLogicalDrives Error is occured !.", "VGFGetLogicalDrives - Error", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                NRMExit(EXIT_CODES.ERROR_FUNCTION_NOT_CALLED);
            }

            uint num = (uint)logicalDrives;
            int num2 = 0;

            while (num != 0)
            {
                if ((num & 1) != 0)
                {
                    num2++;
                }
                num >>= 1;
            }

            string[] array = new string[num2];

            char[] array2 = new char[3]
            {
            'A',
            ':',
            '\\'
            };

            num = (uint)logicalDrives;
            num2 = 0;

            while (num != 0)
            {
                if ((num & 1) != 0)
                {
                    array[num2++] = new string(array2);
                }
                num >>= 1;
                array2[0] += '\u0001';
            }
            return array;
        }

        /// <summary>
        /// Get User Domainname
        /// </summary>
        /// <!-- Author Tippo -->
        /// 
        /// <!--Author Tippo -->
        /// <remarks>
        /// Ruft den Netzwerkdomänennamen ab, der dem aktuellen Benutzer zugeordnet ist.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFUserDomainName()
        {
            
                StringBuilder sb = new StringBuilder(1024);

                int domainNameLen = sb.Capacity;

                byte userNameEx = GetUserNameEx(EXTENDED_NAME_FORMAT.NameDnsDomain, sb, domainNameLen);
                if (userNameEx == 1)
                {
                    string text = sb.ToString();
                    int num = text.IndexOf('\\');
                    if (num != -1)
                    {
                        return text.Substring(0, num);
                    }
                }

                return sb.ToString();
            
        } // VGFUserDomainName























    } // END OF Class::InternalUtilities

} // END OF Namespace::InternalUtilities

/********************** END OF FILE InternalUltilites.cs **********************/

