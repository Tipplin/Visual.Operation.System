
//#############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and Main-Author Christian "TIPPO" Kurs
//-----------------------------------------------------------------------------
// Part		    :	NativeDLL - most written in C/C++
//-----------------------------------------------------------------------------
// Base Class       :	VOSInternalBase
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
using Microsoft.Win32;
using System.Windows.Forms;
using System.Runtime.InteropServices;




//-----------------------------------------------------------------------------
// namespace Visual.Operation.System.Base - internal
// use internal Windows Operation System Base
//-----------------------------------------------------------------------------
// NOTE!: have set Class Registry inside, but is NOT used in Linux and macOS
// have no Registry, compability can set by use .NET CORE 3.0 with:
// nuget:
// Microsoft.Windows.Compatibility package 
// Microsoft.Windows.Compatibility.Shims package 
// for cross over programming: Windows, Linux, macOS X
//-----------------------------------------------------------------------------
// alternate:
// write switch OperationSystem for Windows, Linux, macOS X
//-----------------------------------------------------------------------------
namespace Visual.Operation.System.Base
{
    /// <summary>
    /// Internal Base for Visual Operation System
    /// </summary>
    internal static class VOSInternalBase
    {


        #region ### Global Constants ###


        //---------------------------------------------------------------------
        // Global static constants, variables and more...
        //---------------------------------------------------------------------


        //---------------------------------------------------------------------
        // DON'T USE ! only for show new write for constants,
        // one constants declaration, and more at end with commata, 
        // the last constant with semicolon;
        //
        /*
         *  public const int Example = 1,
                           Example2 = 2,
                           Example3 = 3; // the last constant with semicolon ;
         */
        //---------------------------------------------------------------------
        // as Comment allowed <!-- --> simplesample for Authorname Comment...
        // but not show in Object Viewer by Comments.
        // <!-- Author TIPPO -->
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        // Global Entry Values, read only is OK!
        //---------------------------------------------------------------------
        // without accessmodifizer allways private!
        //---------------------------------------------------------------------
        // ! ATTENTION ! private have now shield factor.
        // private is now standard!
        // public, protected, private protected
        // internal is always after compile HIDDEN, Class, Method, Properties..
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        // Get Value from Registry Key UBR for Revisionnmuber
        // static readonly object releaseKeyAsObject = ndpKey.GetValue("UBR");
        //---------------------------------------------------------------------
        // Get Value from Registry Key EditionID, is the Windows Editions:
        // Home, Professional, Enterprise, S School, E Education, 
        // C Cloud Edition (Fall 2018), China Government
        // static readonly object releaseKeyAsObjectEdition 
        // = ndpKey.GetValue("EditionID");
        //---------------------------------------------------------------------

        /* instance
         * A manifestation of a class, here RegistryKey with Modi static
         * @ is sign for unicode, so only one slash, normall two slashes in Registry Entry.
         * @ unicode sign UTF16, Common Language Runtime - I/O - UTF16
         * 
        */


        /* ----------------------------------------------------------------------
         * set here instancevariable for Class VOSAssemblyInfo in AssemblyInfo.cs
         * in Class Head that's in Visual C# allowed. 
         * See the Class instance on Stack, have no constructor. 
         * Set with new operator then on Heap.
         * vos.propertyname for Information about the Assembly.
         * ! Class VOSAssemblyInfo normally not exists !
         * ----------------------------------------------------------------------
         * structs, classes and more can set in Class Head only once!, so for all
         * Methods used. 
         * ----------------------------------------------------------------------
         * NOTE!: if class is static the set must be static.
         * ----------------------------------------------------------------------
         */

        /// <summary>
        /// Set Global Classes in Class Head. 
        /// set for all Methods in this File.
        /// Set Class VOSAssemblyInfo on Stack with instancevariable vos!
        /// 
        /// </summary>
	/// <!-- Author TIPPLIN -->
	/// Set instancevariable for Class VOSAssemblyInfo without new, so on stack.
	/// <!-- Author TIPPLIN -->
        internal static VOSAssemblyInfo vos;

        //---------------------------------------------------------------------
        // global message for all other files
        // set in other files using static InternalUtilities;
        // directly message = "";
        //---------------------------------------------------------------------
        internal static string vosmessage;

        /// <summary>
        /// Set constant Registry Key Entry
        /// </summary>
        /// <!-- Author Tipplin -->
        /// set short constant CVKey for Registry Key Entry
        /// for @ see overthere by instance.
        /// <!-- Author Tipplin -->
        internal static string CVKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion";


        /// <summary>
        /// GLOBAL CLASS REGISTRY WITH MAIN KEY's AND SUB KEY's:
        /// 
        /// Set class Global Instance and Instancevariable 
        /// for Registry and open constant the Registry Key.
        /// Global Access for all Methods in this File.
        /// </summary>
        /// <!-- Author Tippolin -->
        /// !NOTE! set modi readonly, we want only the Registry Value
        /// readonly, private as shield protection, so no access outside.
        /// Visual C#: 
        /// standard modi internal is private without set!,
        /// so want access of class, set public.
        /// If class is static so set public static, internal static...,
        /// is in this moment same as const.
        /// <!-- Author Tippolin -->
        /// <remarks>
        /// the actual current build on this computer.
        /// static readonly object releaseKeyAsObjectCurrentBuild = ndpKey.GetValue("CurrentBuild");
        /// </remarks>
        internal static RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(CVKey);


        #endregion ### Global Constants ###


        #region ### Global Structs ###
	// Structs later here
        #endregion ### Global Structs ###


        #region ### Global Enumerators ###
		
	/// <summary>
        /// VOSApplicationAction for various Application Actions
        /// </summary>
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// same Actions are bad, same as Info
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// <remarks>
        /// 
        /// </remarks>
        internal enum VOSApplicationAction
        {
            /// <summary>
            /// info for error
            /// </summary>
            VOSAppInformation,
            /// <summary>
            /// warning error
            /// </summary>
            VOSAppWarning,
            /// <summary>
            /// critical error
            /// </summary>
            VOSAppCritical,
            /// <summary>
            /// very fatal error
            /// </summary>
            VOSAppFataleCritical
            
        }

        /// <summary>
        /// Windows Operation System Products
	/// © 1982 - 2020 Copyright by Microsoft Corporation.
        /// </summary>
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// some Products are not supported !
	/// some are written for Chinese People and Government 
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// <remarks>
        /// This parameter can be one of the following values (some products below may be out of support).
        /// </remarks>
        internal enum VOSWindowsProductEdition
        {

            /// <summary>
            /// Business Product
            /// </summary>
            WIN_PRODUCT_BUSINESS = 0x00000006,
            /// <summary>
            /// 
            /// </summary>
            WIN_PRODUCT_BUSINESS_N = 0x00000010,
            /// <summary>
            /// HPC Edition
            /// </summary>
            WIN_PRODUCT_CLUSTER_SERVER = 0x00000012,
            /// <summary>
            /// Server Hyper Core V
            /// </summary>
            WIN_PRODUCT_CLUSTER_SERVER_V = 0x00000040,
            /// <summary>
            /// Windows 10 Home 
            /// </summary>
            WIN_PRODUCT_CORE = 0x00000065,
            /// <summary>
            /// Windows 10 Home China
            /// </summary>
            WIN_PRODUCT_CORE_COUNTRYSPECIFIC = 0x00000063,
            /// <summary>
            /// Windows 10 Home N
            /// </summary>
            WIN_PRODUCT_CORE_N = 0x00000062,
            /// <summary>
            /// Windows 10 Home Single Language
            /// </summary>
            PRODUCT_CORE_SINGLELANGUAGE = 0x00000064,
            /// <summary>
            /// Server Datacenter (evaluation installation)
            /// </summary>
            PRODUCT_DATACENTER_EVALUATION_SERVER = 0x00000050,
            /// <summary>
            /// Server Datacenter, Semi-Annual Channel(core installation)
            /// </summary>
            PRODUCT_DATACENTER_A_SERVER_CORE = 0x00000091,
            /// <summary>
            /// Server Standard, Semi-Annual Channel(core installation)
            /// </summary>
            PRODUCT_STANDARD_A_SERVER_CORE = 0x00000092,
            /// <summary>
            /// Server Datacenter(full installation. 
            /// For Server Core installations of Windows Server 2012 and 
            /// later, use the method, Determining whether Server Core is running.)
            /// </summary>
            PRODUCT_DATACENTER_SERVER = 0x00000008,
            /// <summary>
            /// Server Datacenter(core installation, Windows Server 2008 R2 and earlier)
            /// </summary>
            PRODUCT_DATACENTER_SERVER_CORE = 0x0000000C,
            /// <summary>
            /// Server Datacenter without Hyper-V(core installation)
            /// </summary>
            PRODUCT_DATACENTER_SERVER_CORE_V = 0x00000027,
            /// <summary>
            /// Server Datacenter without Hyper-V(full installation)
            /// </summary>
            PRODUCT_DATACENTER_SERVER_V = 0x00000025,
            /// <summary>
            /// Windows 10 Education
            /// </summary>
            PRODUCT_EDUCATION = 0x00000079,
            /// <summary>
            /// Windows 10 Education N
            /// </summary>
            PRODUCT_EDUCATION_N = 0x0000007A,
            /// <summary>
            /// Windows 10 Enterprise
            /// </summary>
            PRODUCT_ENTERPRISE = 0x00000004,
            /// <summary>
            /// Windows 10 Enterprise E
            /// </summary>
            PRODUCT_ENTERPRISE_E = 0x00000046,
            /// <summary>
            /// Windows 10 Enterprise Evaluation
            /// </summary>
            PRODUCT_ENTERPRISE_EVALUATION = 0x00000048,
            /// <summary>
            /// Windows 10 Enterprise N
            /// </summary>
            PRODUCT_ENTERPRISE_N = 0x0000001B,
            /// <summary>
            /// Windows 10 Enterprise N Evaluation
            /// </summary>
            PRODUCT_ENTERPRISE_N_EVALUATION = 0x00000054,
            /// <summary>
            /// Windows 10 Enterprise 2015 LTSB
            /// </summary>
            PRODUCT_ENTERPRISE_S = 0x0000007D,
            /// <summary>
            /// Windows 10 Enterprise 2015 LTSB Evaluation
            /// </summary>
            PRODUCT_ENTERPRISE_S_EVALUATION = 0x00000081,
            /// <summary>
            /// Windows 10 Enterprise 2015 LTSB N
            /// </summary>
            PRODUCT_ENTERPRISE_S_N = 0x0000007E,
            /// <summary>
            /// Windows 10 Enterprise 2015 LTSB N Evaluation
            /// </summary>
            PRODUCT_ENTERPRISE_S_N_EVALUATION = 0x00000082,
            /// <summary>
            /// Server Enterprise(full installation)
            /// </summary>
            PRODUCT_ENTERPRISE_SERVER = 0x0000000A,
            /// <summary>
            /// Server Enterprise(core installation)
            /// </summary>
            PRODUCT_ENTERPRISE_SERVER_CORE = 0x0000000E,
            /// <summary>
            /// Server Enterprise without Hyper-V(core installation)
            /// </summary>
            PRODUCT_ENTERPRISE_SERVER_CORE_V = 0x00000029,
            /// <summary>
            /// Server Enterprise for Itanium-based Systems
            /// </summary>
            PRODUCT_ENTERPRISE_SERVER_IA64 = 0x0000000F,
            /// <summary>
            /// Server Enterprise without Hyper-V(full installation)
            /// </summary>
            PRODUCT_ENTERPRISE_SERVER_V = 0x00000026,
            /// <summary>
            /// Windows Essential Server Solution Additional
            /// </summary>
            PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL = 0x0000003C,
            /// <summary>
            /// Windows Essential Server Solution Additional SVC
            /// </summary>
            PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC = 0x0000003E,
            /// <summary>
            /// Windows Essential Server Solution Management
            /// </summary>
            PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT = 0x0000003B,
            /// <summary>
            /// Windows Essential Server Solution Management SVC
            /// </summary>
            PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC = 0x0000003D,
            /// <summary>
            /// Home Basic
            /// </summary>
            PRODUCT_HOME_BASIC = 0x00000002,
            /// <summary>
            /// Not supportes
            /// </summary>
            PRODUCT_HOME_BASIC_E = 0x00000043,
            /// <summary>
            /// Home Basic N
            /// </summary>
            PRODUCT_HOME_BASIC_N = 0x00000005,
            /// <summary>
            /// Home Premium
            /// </summary>
            PRODUCT_HOME_PREMIUM = 0x00000003,
            /// <summary>
            /// Not supported
            /// </summary>
            PRODUCT_HOME_PREMIUM_E = 0x00000044,
            /// <summary>
            /// Home Premium N
            /// </summary>
            PRODUCT_HOME_PREMIUM_N = 0x0000001A,
            /// <summary>
            /// Windows Home Server 2011
            /// </summary>
            PRODUCT_HOME_PREMIUM_SERVER = 0x00000022,
            /// <summary>
            /// Windows Storage Server 2008 R2 Essentials
            /// </summary>
            PRODUCT_HOME_SERVER = 0x00000013,
            /// <summary>
            /// Microsoft Hyper-V Server
            /// </summary>
            PRODUCT_HYPERV = 0x0000002A,
            /// <summary>
            /// Windows 10 IoT Core
            /// </summary>
            PRODUCT_IOTUAP = 0x0000007B,
            /// <summary>
            /// Windows 10 IoT Core Commercial
            /// </summary>
            PRODUCT_IOTUAPCOMMERCIAL = 0x00000083,
            /// <summary>
            /// Windows Essential Business Server Management Server
            /// </summary>
            PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT = 0x0000001E,
            /// <summary>
            /// Windows Essential Business Server Messaging Server
            /// </summary>
            PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING = 0x00000020,
            /// <summary>
            /// Windows Essential Business Server Security Server
            /// </summary>
            PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY = 0x0000001F,
            /// <summary>
            /// Windows 10 Mobile
            /// </summary>
            PRODUCT_MOBILE_CORE = 0x00000068,
            /// <summary>
            /// Windows 10 Mobile Enterprise
            /// </summary>
            PRODUCT_MOBILE_ENTERPRISE = 0x00000085,
            /// <summary>
            /// Windows MultiPoint Server Premium(full installation)
            /// </summary>
            PRODUCT_MULTIPOINT_PREMIUM_SERVER = 0x0000004D,
            /// <summary>
            /// Windows MultiPoint Server Standard(full installation)
            /// </summary>
            PRODUCT_MULTIPOINT_STANDARD_SERVER = 0x0000004C,

            /// <summary>
            /// Windows 10 Professional 
            /// </summary>
	    /// <!-- Author TIPPLIN -->
	    /// remarks info by TIPPLIN
	    /// <!-- Author TIPPLIN -->
            /// <remarks>
            /// Windows 10 Professional Edition is an Workstation:
            /// Limit RAM 2 Terabyte - 2 Processors
            /// Inside Windows Database 'Recent' maximal 16 Terabyte.
            /// Database for Services, Events, Storage, Recovery an Program/Projectsolution
            /// Project-Solution have an copy in Folder App,
            /// this Folder is secure, no delete, no move, only copy in orignal folder.
            /// 
            /// </remarks>
            PRODUCT_PRO_ = 0x000000A2,
            
            /// <summary>
            /// Windows 10 Pro for Workstations
            /// </summary>
            /// <remarks>
            /// Network with Fileserver and Workstations,
            /// Limit RAM 6 Terabyte, 4 Processors 
            /// </remarks>
            PRODUCT_PRO_WORKSTATION = 0x000000A1,
            /// <summary>
            /// Windows 10 Pro for Workstations N
            /// </summary>
            PRODUCT_PRO_WORKSTATION_N = 0x000000A2,
            /// <summary>
            /// Windows 10 Pro
            /// </summary>
            PRODUCT_PROFESSIONAL = 0x00000030,
            /// <summary>
            /// Not supported
            /// </summary>
            PRODUCT_PROFESSIONAL_E = 0x00000045,
            /// <summary>
            /// Windows 10 Pro N
            /// </summary>
            PRODUCT_PROFESSIONAL_N = 0x00000031,
            /// <summary>
            /// Professional with Media Center
            /// </summary>
            PRODUCT_PROFESSIONAL_WMC = 0x00000067,
            /// <summary>
            /// Windows Small Business Server 2011 Essentials
            /// </summary>
            PRODUCT_SB_SOLUTION_SERVER = 0x00000032,
            /// <summary>
            /// Server For SB Solutions EM
            /// </summary>
            PRODUCT_SB_SOLUTION_SERVER_EM = 0x00000036,
            /// <summary>
            /// Server For SB Solutions
            /// </summary>
            PRODUCT_SERVER_FOR_SB_SOLUTIONS = 0x00000033,
            /// <summary>
            /// Server For SB Solutions EM
            /// </summary>
            PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM = 0x00000037,
            /// <summary>
            /// Windows Server 2008 for Windows Essential Server Solutions
            /// </summary>
            PRODUCT_SERVER_FOR_SMALLBUSINESS = 0x00000018,
            /// <summary>
            /// Windows Server 2008 without Hyper-V for Windows Essential Server Solutions
            /// </summary>
            PRODUCT_SERVER_FOR_SMALLBUSINESS_V = 0x00000023,
            /// <summary>
            /// Server Foundation
            /// </summary>
            PRODUCT_SERVER_FOUNDATION = 0x00000021,
            /// <summary>
            /// Windows Small Business Server
            /// </summary>
            PRODUCT_SMALLBUSINESS_SERVER = 0x00000009,
            /// <summary>
            /// Small Business Server Premium
            /// </summary>
            PRODUCT_SMALLBUSINESS_SERVER_PREMIUM = 0x00000019,
            /// <summary>
            /// Small Business Server Premium(core installation)
            /// </summary>
            PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE = 0x0000003F,
            /// <summary>
            /// Windows MultiPoint Server
            /// </summary>
            PRODUCT_SOLUTION_EMBEDDEDSERVER = 0x00000038,
            /// <summary>
            /// Server Standard(evaluation installation)
            /// </summary>
            PRODUCT_STANDARD_EVALUATION_SERVER = 0x0000004F,
            /// <summary>
            /// Server Standard(full installation. 
            /// For Server Core installations of Windows Server 2012 
            /// and later, use the method, Determining whether Server Core is running.)
            /// </summary>
            PRODUCT_STANDARD_SERVER = 0x00000007,
            /// <summary>
            /// Server Standard(core installation, Windows Server 2008 R2 and earlier)
            /// </summary>
            PRODUCT_STANDARD_SERVER_CORE = 0x0000000D,
            /// <summary>
            /// Server Standard without Hyper-V(core installation)
            /// </summary>
            PRODUCT_STANDARD_SERVER_CORE_V = 0x00000028,
            /// <summary>
            /// Server Standard without Hyper-V
            /// </summary>
            PRODUCT_STANDARD_SERVER_V = 0x00000024,
            /// <summary>
            /// Server Solutions Premium
            /// </summary>
            PRODUCT_STANDARD_SERVER_SOLUTIONS = 0x00000034,
            /// <summary>
            /// Server Solutions Premium(core installation)
            /// </summary>
            PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE = 0x00000035,
            /// <summary>
            /// Starter
            /// </summary>
            PRODUCT_STARTER = 0x0000000B,
            /// <summary>
            /// Not supported
            /// </summary>
            PRODUCT_STARTER_E = 0x00000042,
            /// <summary>
            /// Starter N
            /// </summary>
            PRODUCT_STARTER_N = 0x0000002F,
            /// <summary>
            /// Storage Server Enterprise
            /// </summary>
            PRODUCT_STORAGE_ENTERPRISE_SERVER = 0x00000017,
            /// <summary>
            /// Storage Server Enterprise(core installation)
            /// </summary>
            PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE = 0x0000002E,
            /// <summary>
            /// Storage Server Express
            /// </summary>
            PRODUCT_STORAGE_EXPRESS_SERVER = 0x00000014,
            /// <summary>
            /// Storage Server Express(core installation)
            /// </summary>
            PRODUCT_STORAGE_EXPRESS_SERVER_CORE = 0x0000002B,
            /// <summary>
            /// Storage Server Standard(evaluation installation)
            /// </summary>
            PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER = 0x00000060,
            /// <summary>
            /// Storage Server Standard
            /// </summary>
            PRODUCT_STORAGE_STANDARD_SERVER = 0x00000015,
            /// <summary>
            /// Storage Server Standard(core installation)
            /// </summary>
            PRODUCT_STORAGE_STANDARD_SERVER_CORE = 0x0000002C,
            /// <summary>
            /// Storage Server Workgroup(evaluation installation)
            /// </summary>
            PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER = 0x0000005F,
            /// <summary>
            /// Storage Server Workgroup
            /// </summary>
            PRODUCT_STORAGE_WORKGROUP_SERVER = 0x00000016,
            /// <summary>
            /// Storage Server Workgroup(core installation)
            /// </summary>
            PRODUCT_STORAGE_WORKGROUP_SERVER_CORE = 0x0000002D,
            /// <summary>
            /// Ultimate
            /// </summary>
            PRODUCT_ULTIMATE = 0x00000001,
            /// <summary>
            /// Not supported
            /// </summary>
            PRODUCT_ULTIMATE_E = 0x00000047,
            /// <summary>
            /// Ultimate N
            /// </summary>
            PRODUCT_ULTIMATE_N = 0x0000001C,
            /// <summary>
            /// An unknown product
            /// </summary>
            PRODUCT_UNDEFINED = 0x00000000,
            /// <summary>
            /// Web Server(full installation)
            /// </summary>
            PRODUCT_WEB_SERVER = 0x00000011,
            /// <summary>
            /// Web Server(core installation)
            /// </summary>
            PRODUCT_WEB_SERVER_CORE = 0x0000001D


        } // END_OF_ENUM WindowsProductEdition



        /// <summary>
        ///  Gibt den Typ des Windows-Kontos verwendet.
        /// </summary>
        internal enum WindowsAccountType
        {
            /// <summary>
            /// Windows Standard User Account.
            /// </summary>
            Normal,
            /// <summary>
            /// Windows-Guest Account.
            /// </summary>
            Guest,
            /// <summary>
            /// Windows-System Account.
            /// </summary>
            System,
            /// <summary>
            /// Anonymous Account.
            /// </summary>
            Anonymous
        }

        /// <summary>
        /// Main Windows Memmbership, at newer Windows come more by.
        /// All in .NET Framework under NTAccounts, System.Security.Permission,
        /// </summary>
        internal enum WindowsBuiltInRole
        {
            /// <summary>
            /// ACHTUNG !:
            /// Administratoren haben vollständigen und uneingeschränkten Zugriff auf den Computer oder die Domäne.
	    /// ----------------------=============-----=========================
	    /// Administrator have full access on Computer, can be set.
            /// That's the Different to User!. Windows 10 Professional blocked Folders by Account User. No Access!
            /// </summary>
            Administrator = 544,
            
            /// <summary>
            ///  Benutzer werden daran gehindert, versehentliche oder absichtliche systemweite Änderungen vornehmen.
            ///  Benutzer können daher zertifizierte Anwendungen, jedoch nicht von den meisten Legacyanwendungen ausgeführt werden.
            ///  ACHTUNG ! Windows 10 behält sich vor hier einige Ordner zu schützen, kein Zugriff !.
            /// </summary>
            User,
            
            /// <summary>
            /// Gäste sind mehr eingeschränkt als Benutzer.
            /// </summary>
            Guest,
            
            /// <summary>
            /// Hauptbenutzer verfügen die meisten administrative Berechtigungen mit einigen Einschränkungen.
            /// Daher können Hauptbenutzer Legacyanwendungen, zusätzlich zu den zertifizierten Anwendungen ausgeführt werden.
            /// </summary>
            PowerUser,
            
            /// <summary>
            /// Kontooperatoren verwalten die Benutzerkonten auf einem Computer oder einer Domäne.
            /// </summary>
            AccountOperator,
            
            /// <summary>
            /// Systemoperatoren verwalten einen bestimmten Computer.
            /// </summary>
            SystemOperator,
            
            /// <summary>
            /// Druck-Operatoren können einen Drucker steuern.
            /// </summary>
            PrintOperator,
            
            /// <summary>
            /// Sicherungsoperatoren können Sicherheitsrichtlinien für den Zweck, sichern oder Wiederherstellen von Dateien überschreiben.
            /// </summary>
            BackupOperator,

            /// <summary>
            /// Replikationsdienste unterstützen die Dateireplikation in einer Domäne.
            /// </summary>
            Replicator
        }


        #endregion

        /*---------------------------------------------------------------------
         * Windows 10 Multi User Set, 
	 * while Windows 10 is Multi User System (at Professional)
         * One User or more User on one Computer.
         * any User set free username, 
         * but (User) SID set Windows 10 for any User.
         * 
         --------------------------------------------------------------------*/
		
        /// <summary>
        /// Gibt eine Zeichenfolge zurück, die den Namen der .NET-Installation angibt, auf der eine App ausgeführt wird.
        /// </summary>
        /// <!-- Author TIPPLIN 🧑-->
        /// 
        /// <!-- Author TIPPLIN 🧑-->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// Der Name der .NET-Installation, auf der die App ausgeführt wird.
        /// </returns>
        public static string VOSGetFrameworkIsPresent(string ApplicationName)
        {
            return string.Format("Application {0} runs under this Framework {1}", ApplicationName, RuntimeInformation.FrameworkDescription);
        }

        /// <summary>
        /// Gibt an, ob die aktuelle Anwendung auf der angegebenen Plattform ausgeführt wird.
        /// </summary>
        /// <!-- Author TIPPLIN 🧑-->
        /// 
        /// <!-- Author TIPPLIN 🧑-->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// Eine Plattform.
        /// </returns>
        public static string VOSGetPlatformName()
        {
            return string.Format("{0}", "Current Application runs on Platform Windows", RuntimeInformation.IsOSPlatform(OSPlatform.Windows).ToString() );
        }

        /// <summary>
        /// Ruft eine Zeichenfolge ab, die den Namen des Betriebssystems angibt, auf dem die App ausgeführt wird.
        /// </summary>
        /// <!-- Author TIPPLIN 🧑-->
        /// 
        /// <!-- Author TIPPLIN 🧑-->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// Der Name des Betriebssystems, auf dem die App ausgeführt wird.
        /// </returns>
        public static string VOSGetOperationSystemName()
        {
            return string.Format("{0}", "Operation System", RuntimeInformation.OSDescription);
        }

        /// <summary>
        ///  Ruft die Prozessarchitektur einer aktuell ausgeführten App ab.
        /// </summary>
        /// <!-- Author TIPPLIN 🧑-->
        /// 
        /// <!-- Author TIPPLIN 🧑-->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// X86 - Eine Intel-basierte 32-Bit-Prozessorarchitektur.
        /// X64 - Eine Intel-basierte 64-Bit-Prozessorarchitektur.
        /// ARM - Eine 32-Bit-ARM-Prozessorarchitektur.
        /// ARM64 - Eine 64-Bit-ARM-Prozessorarchitektur.
        /// </returns>
        public static string VOSGetProcessorArchitectureName()
        {
            return string.Format("{0}", "Processor Architecture", RuntimeInformation.ProcessArchitecture);
        }
        

        
    } // end of class::VOSInternalBase

} // end of namespace:: Visual.Operation.System.Base
