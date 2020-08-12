




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
    /// 
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

        //---------------------------------------------------------------------
        // Struct Restriction for Userprofile File: upf.userconfig
        // upf.userconfig can crypt for unauthorized access/use.
        //---------------------------------------------------------------------
        // Windows 10 allowed length .suffixes, standard and your own.
        // (Limit 255 Chars prefix.suffix)
        // Windows 10 File Associations (New File System)
        // sample: Microsoft Access Database:
        // .accdb=Access.Application.16
        //---------------------------------------------------------------------

        // TODO - Members at Time NOT in USE ! Later with Methods...

        /// <summary>
        /// Our User Profile Account
        /// </summary>
        internal struct UserAccountRestriction
        {
            /// <summary>
            /// Set Expires Year for User Account
            /// </summary>
            public byte AccountExpiresYear;
            /// <summary>
            /// Set Expires Month for User Account
            /// </summary>
            public byte AccountExpiresMonth;
            /// <summary>
            /// Set Expires Day for User Account
            /// </summary>
            public byte AccountExpiresDay;
            /// <summary>
            /// Set the User Account is expired
            /// </summary>
            public byte AccountExpired;
            /// <summary>
            /// Set the User Password expired Year
            /// </summary>
            public byte PasswordExpiresYear;
            /// <summary>
            /// Set the User Password expired Mear
            /// </summary>
            public byte PasswordExpiresMonth;
            /// <summary>
            /// Set the User Password expired Day
            /// </summary>
            public byte PasswordExpiresDay;
            /// <summary>
            /// Set the User Password Grace Logins
            /// </summary>
            public byte PasswordGraceLogins;
            /// <summary>
            /// Set the User Account Expiration Interval Value
            /// </summary>
            public short ExpirationInterval;
            /// <summary>
            /// Set the User Grace Reset
            /// </summary>
            public byte GraceReset;
            /// <summary>
            /// Intel Password Guideline 8 Chars minimum,
            /// Intel internal validate the Password strongly.
            /// Online Password check by Kaspersky Lab,
            /// make a Brute Force Attack - returned Message to User:
            /// Bullshit, Middle, OK
            /// </summary>
            public byte MinimumPasswordLength;
            /// <summary>
            /// Set the Maximum Network Concurrent Connections
            /// </summary>
            public short MaxNetConcurrentConnections;
            /// <summary>
            /// Set the User Account Last Login Date
            /// </summary>
            public byte LastLoginDate;
            /// <summary>
            /// Set Administrator Restriction Flags,
            /// OS-System-Function SHRestriction(enum Restriction);
            /// Admin can allowed or not allowed, start apps, services,
            /// remove menueitems from START-Menue, NOCDBurning, NOUSB,
            /// NOWEB,
            /// Admin create for User settings, what can he starts.
            /// </summary>
            public byte RestrictionFlags;
            /// <summary>
            /// Maximum Disk Blocks
            /// </summary>
            public long MaxDiskBlocks;
            /// <summary>
            /// Set User Account Bad Login Count
            /// </summary>
            public short BadLoginCount;
            /// <summary>
            /// Set Next Reset System Time
            /// </summary>
            public long NextResetTime;
            /// <summary>
            /// Set User Account Bad Station Address
            /// </summary>
            public byte BadStationAddress;
        }







        #endregion ### Global Structs ###


        #region ### Enumerators ###

        internal enum ApplicationAction
        {
            /// <summary>
            /// info for error
            /// </summary>
            Information,
            /// <summary>
            /// warning error
            /// </summary>
            Warning,
            /// <summary>
            /// critical error
            /// </summary>
            Critical,
            /// <summary>
            /// very fatal error
            /// </summary>
            FataleCritical
            
        }





        /// <summary>
        /// Windows Operation System Products
        /// </summary>
        /// <!-- Author Tipplin -->
        /// some are not supported
        /// <!-- Authore Tipplin -->
        /// <remarks>
        /// This parameter can be one of the following values (some products below may be out of support).
        /// </remarks>
        internal enum WindowsProductEdition
        {

            /// <summary>
            /// Business Product
            /// </summary>
            PRODUCT_BUSINESS = 0x00000006,
            /// <summary>
            /// 
            /// </summary>
            PRODUCT_BUSINESS_N = 0x00000010,
            /// <summary>
            /// HPC Edition
            /// </summary>
            PRODUCT_CLUSTER_SERVER = 0x00000012,
            /// <summary>
            /// Server Hyper Core V
            /// </summary>
            PRODUCT_CLUSTER_SERVER_V = 0x00000040,
            /// <summary>
            /// Windows 10 Home 
            /// </summary>
            PRODUCT_CORE = 0x00000065,
            /// <summary>
            /// Windows 10 Home China
            /// </summary>
            PRODUCT_CORE_COUNTRYSPECIFIC = 0x00000063,
            /// <summary>
            /// Windows 10 Home N
            /// </summary>
            PRODUCT_CORE_N = 0x00000062,
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
            /// <remarks>
            /// Is an Workstation:
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

            /* Windows 10 Professional Edition - Windows Membership:
                *Administratoren
                *Benutzer
                *Distributed COM-Benutzer
                *Ereignisprotokollleser
                *Gäste
                *Hauptbenutzer
                *Hyper-V-Administratoren
                *IIS_IUSRS
                *Kryptografie-Operatoren
                *Leistungsprotokollbenutzer
                *Leistungsüberwachungsbenutzer
                *Netzwerkkonfigurations-Operatoren
                *PVGF
                *Remotedesktopbenutzer
                *Remoteverwaltungsbenutzer
                *Replikations-Operator
                *Sicherungs-Operatoren
                *Ssh Users
                *System Managed Accounts Group
                *WmsOperators
                *Zugriffssteuerungs-Unterstützungsoperatoren
                * 
                * if install Microsoft SQL Server come more
            */









        }


        #endregion

        /*---------------------------------------------------------------------
         * Windows 10 User Set, while Windows 10 is Multi User System (Prof)
         * One User or more User on one Computer.
         * any User set free username, 
         * but (User) SID set Windows 10 for any User.
         * 
         * -------------------------------------------------------------------
         * Windows 10 Professional Edition:
         * Role Computers:                                      WORKSTATION
         * -------------------------------------------------------------------
         * 
         * Username   User SID
         * ===================== ==============================================
         * desktop-mnk3mvk\tippo S-1-5-21-3373537164-1258717689-2658483839-1002
         * 
         *---------------------------------------------------------------------
         */

        /* Ruft ein Objekt ab, das das Windows-Betriebssystem darstellt.
         * Ein Objekt, das das Windows-Betriebssystem darstellt.
         * 
         * now internal set Windows, Linux, macOS, Unix, XBOX
         * now next Framework - Microsoft make Bridges to other Operation Systems
         * Windows, Linux, macOS, Unix, XBOX, Android, iOS
         * 
         * 
        public static OSPlatform Windows
        {
            get;
        } = new OSPlatform("WINDOWS");
        */





        /// <summary>
        /// Gibt eine Zeichenfolge zurück, die den Namen der .NET-Installation angibt, auf der eine App ausgeführt wird.
        /// </summary>
        /// <!-- Author Tippo 🧑-->
        /// 
        /// <!-- Author Tippo 🧑-->
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
        /// <!-- Author Tippo 🧑-->
        /// 
        /// <!-- Author Tippo 🧑-->
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
        /// <!-- Author Tippo 🧑-->
        /// 
        /// <!-- Author Tippo 🧑-->
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
        /// <!-- Author Tippo 🧑-->
        /// 
        /// <!-- Author Tippo 🧑-->
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




        /*******************************************************************************************************************************
         * Für alle .NET Entwickler einige Informationen - bewährtes, neues, zukünftiges...
         * ----------------------------------------------------------------------------------------------------------------------------
         * ab nächstes Jahr 2020 im November (höchstwahrscheinlich) 
         * nur noch eine Platform .NET 5 für alle Geräate, WinForms, WPF, XAML...
         * Microsoft Windows 10 ist jetzt Open Source, teile wurden mit Quellcodes veröffentlicht auf Microsoft GitHub.
         * Mitarbeit erwünscht, Wünsche, Kritik, Bugs...
         * Rechner mit Erweiterungen ----------------> C++
         * Windows Terminal (cmd, conhost.exe)-------> C++
         * Windows Implementation Libraries (WIL) ---> C++
         * 
         * Windows Research Kernel Quellcode nur ----> C
         * 
         * 
         * Enthält die Laufwerk den vollqualifizierten Pfad und Dateinamen einer Hilfedatei mit weiteren Informationen über den Fehler.
         * public string bstrHelpFile;
         * 
         * Gibt die Hilfekontext-ID des Themas in der Hilfedatei.
         * public int dwHelpContext;
         * 
         * 
         * Visual Studio 2019 ist Run Analysis einschaltet.
         * Macht Vorschläge was man verbessern kann, besonders bei unmanaged code teile
         * die aus einer nativen Dynamic Link Library kommen.
         * z. b. unsere Visual.Function.Library.dll in C geschrieben.
         * sollten diese instellungen mit übernommen werden in das:
         * [DllImportAttribute("vfl.dll", EntryPoint ="funktionname", SetLastError = true, BestFitMapping = true,  ThrowOnUnmappableChar = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.stdcall)]
         * 
         * Aktiviert oder deaktiviert die Zuordnung mit ähnlichen Verhalten bei der Konvertierung von Unicode-Zeichen in ANSI-Zeichen.
         * public bool BestFitMapping;
         * 
         * Aktiviert bzw. deaktiviert das Auslösen einer Ausnahme bei einer nicht zuzuordnenden Unicode-Zeichen, die in ein ANSI konvertiert wird "?" Zeichen.
         * public bool ThrowOnUnmappableChar
         * 
         * Fälscherweise setzen einige Entwickler diese CallingConvention bei Windows Funktionen:
         * Dieser Member ist nicht tatsächlich eine Aufrufkonvention, sondern verwendet die Standardkonvention für Plattformaufrufe.
         * Winapi
         * 
         * sondern 
         * 
         * Der aufgerufene entleert den Stapel.
         * Dies ist die Standardkonvention für das aufrufende nicht verwaltete Funktionen mit Plattformaufruf.
         * StdCall
         * 
         * NOTE: dieser CallingCovnetion Cdecl braucht man bei nativen Libraries wie:
         * Alle Microsoft C/C++ Runtime Libraries 
         * (JA, es gibt mehrere !, sogar eine pur in 64BIT geschrieben.)
         * 
         * 
         * Der Aufrufer bereinigt den Stapel.
         * Auf diese Weise können aufrufende Funktionen mit, wodurch die Verwendung für Methoden, 
         * die eine Variable Anzahl von Parametern, z. B. akzeptieren Printf.
         * Cdecl
         * 
         * CharSet, immer Unicode nehmen !
         * Automatisch Marshallen von Zeichenfolgen für das Ziel-Betriebssystem.
         * Der Standardwert ist auf Windows NT, Windows 2000, Windows XP und Windows Server 2003-Produktfamilie; 
         * der Standardwert ist .Ansi unter Windows 98 und Windows Me.
         * 
         * ! ACHTUNG ! bei CharSet.Auto bei Programmiersprache Visual C#:
         * Obwohl die common Language Runtime-Standard ist, Sprachen können diese Standardeinstellung außer Kraft setzen.
         * Beispielsweise standardmäßig Visual C# markiert alle Methoden und Typen als .Ansi
         * (wird dann intern umgewandelt von .Auto nach .Ansi)
         *
         * Ansi     - Marshallen von Zeichenfolgen als Zeichenfolgen mit mehreren Byte-Zeichen.
         * Unicode  - Marshallen von Zeichenfolgen als Unicode-2-Byte-Zeichen.
         * 
         * DllImportSearchPath bitte nicht setzen !
         * Internal schon gesetzt, Dll Suche in allen Verzeichnissen.
         * Gibt die Pfade an, die bei der Suche nach DLLs verwendet werden, die Funktionen für Plattformaufrufe bereitstellen.
         * 
         * Nur einzelne Setzen wenn man sich sicher, das die DLL in diesem Verzeichnis steht:
         * 
         * UseDllDirectoryForDependencies,
         * Suchen Sie die Abhängigkeiten einer DLL im Ordner, wenn die DLL befindet, bevor Sie andere Ordner suchen
         * 
         * Schließen Sie das Verzeichnis der Anwendung in der DLL-Suchpfad.
         * ApplicationDirectory 
         * 
         * Jeder Pfad, explizit die Prozess-und computerweiter Suchpfad hinzugefügt wurde, mithilfe der Win32- AddDllDirectory Funktion.
         * UserDirectories 
         * 
         * Enthalten die %WinDir%\System32 Verzeichnis in der DLL-Suchpfad.
         * System32
         * 
         * Das Anwendungsverzeichnis enthalten die %WinDir%\System32 Directory und in der DLL-Suchpfad in Verzeichnissen nach Benutzer.
         * SafeDirectories
         * 
         * Bei der Suche nach Assemblyabhängigkeiten das Verzeichnis, das die Assembly selbst enthält, und suchen Sie das Verzeichnis zunächst.
         * Dieser Wert wird von .NET Framework verwendet, bevor die Pfade der Win32-übergeben werden LoadLibraryEx Funktion.
         * AssemblyDirectory
         * 
         * Suchen Sie das Anwendungsverzeichnis, und rufen Sie dann die Win32 LoadLibraryEx-Funktion mit der LOAD_WITH_ALTERED_SEARCH_PATH Flag.
         * Dieser Wert wird ignoriert, wenn ein anderer Wert angegeben ist.
         * Betriebssysteme, die nicht die System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute, 
         * Attribut verwenden Sie diesen Wert, und die anderen Werte ignoriert.
         * LegacyBehavior
         * 
         * 
         * Microsoft Regeln
         * Alle Dynamic Link Library in C/C++ geschrieben, für Visual C# nutzen,
         * sollen in drei Klassen geschrieben werden,
         * NativeMethods
         * UnsafeNativeMethods
         * SafeNativeMethods
         * 
         * System.Security.SuppressUnmanagedCodeSecurityAttribute
         * Ermöglicht es verwaltetem Code, nicht verwalteten Code ohne Stackwalk aufzurufen.
         * SuppressUnmanagedCodeSecurityAttribute
         * 
         * System.Security.UnverifiableCodeAttribute
         * Kennzeichnet Module, die nicht überprüfbaren Code enthalten.
         * Diese Klasse kann nicht vererbt werden.
         * 
         * System.Runtime.Remoting.Metadata
         * System.Runtime.Remoting.Metadata.W3cXsd2001
         * Bietet Zugriff auf die XML-Schemadefinitionssprache (XSD) eines SOAP-Typs.
         * SOAP Klassen
         * 
         * System.Runtime.Remoting.Channels.ChannelServices
         * Stellt statische Methoden zur Unterstützung bei der Registrierung von Remotechannels, Auflösung und URL-Suche.
         * 
         * Diese Ausnahme wird ausgelöst, um dem Client Fehler zu übermitteln, 
         * wenn dieser eine Verbindung mit nicht in .NET Framework erstellten Anwendungen herstellt, 
         * die selbst keine Ausnahmen auslösen können.
         * System.Runtime.Remoting.ServerException
         * System.Runtime.Remoting.RemotingException
         * System.Runtime.Remoting.RemotingTimeoutException
         * 
         * Stellt Hilfsmethoden für das Marshalling von Daten zwischen .NET Framework und Windows-Runtime bereit.
         * System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal
         * 
         * Definiert die Implementierungsdetails für eine Methode.
         * System.Runtime.CompilerServices.MethodImplOptions
         * MethodImplementationAttribute
         * 
         * Der Aufruf ist intern, d.h. es wird eine Methode aufgerufen, die innerhalb der Common Language Runtime implementiert wird.
         * InternalCall
         * 
         * Die Methode kann nicht intern sein.
         * Inlining ist eine Optimierung, bei der der Aufruf einer Methode durch den Methodentext ersetzt wird.
         * NoInlining
         * 
         * Die Methode sollte möglichst intern sein.
         * AggressiveInlining
         * 
         * [Wird nur in .NET Framework 4.5.1 und neueren Versionen unterstützt] 
         * Ruft einen Wert ab oder legt ihn fest, der angibt, ob eine vollständige blockierende Garbage Collection den großen Objektheap (LOH) komprimiert.
         * 
         * System.Reflection.Assembly
         * Lädt eine Assembly bei Angabe des Anzeigenamens oder Pfads.
         * LoadFrom(string assemblyFile)
         * 
         * System.Collections.Generic.List<T>
         * Stellt eine stark typisierte Liste von Objekten dar, auf die über einen Index zugegriffen werden kann.
         * Stellt Methoden zum Durchsuchen, Sortieren und Bearbeiten von Listen bereit.
         * 
         * System.Diagnostics.Debugger
         * Ermöglicht die Kommunikation mit einem Debugger.
         * System.Diagnostics.StackTrace
         * System.Diagnostics.StackFrame
         * 
         * Die Ausnahme, die ausgelöst wird, 
         * wenn das Betriebssystem aufgrund eines E/A-Fehlers 
         * oder 
         * eines bestimmten Typs von Sicherheitsfehler den Zugriff verweigert.
         * System.UnauthorizedAccessException
         * 
         * Die Ausnahme, die ausgelöst wird, wenn eine Funktion nicht auf einer bestimmten Plattform ausgeführt werden kann.
         * System.PlatformNotSupportedException
         * 
         * System.TimeoutException
         * 
         * Die Ausnahme, die ausgelöst wird, wenn ein Array mit der falschen Anzahl von Dimensionen an eine Methode übergeben wird.
         * System.RankException
         * 
         * Stellt die Informationen über ein Betriebssystem dar, wie Versions- und Plattformbezeichner.
         * System.OperatingSystem
         * 
         * Stellt Konstanten und statische Methoden für trigonometrische, logarithmische und andere gebräuchliche mathematische Funktionen bereit.
         * System.Math
         * public const double PI = 3.1415926535897931;
         * 
         * Stellt die Basis des natürlichen Logarithmus durch die Konstante dar.
         * public const double E = 2.7182818284590451;
         * 
         * Gibt einen Winkel zurück, dessen Kosinus die angegebene Zahl ist.
         * public static extern double Acos(double d);
         * 
         * System.Environment
         * Windows Operation System Ordern/Folders
         * Gibt Enumerationskonstanten an, mit denen Verzeichnispfade für besondere Systemordner abgerufen werden.
         * 
         * public enum SpecialFolder
         * {
		/// <summary>
		///         Das Verzeichnis, das als allgemeines Repository für programmspezifische Daten des aktuellen Roamingbenutzers verwendet wird.
		///       </summary>
		ApplicationData = 26,
		/// <summary>
		///         Das Verzeichnis, das als allgemeines Repository für programmspezifische Daten verwendet wird, die von allen Benutzern verwendet werden.
		///       </summary>
		CommonApplicationData = 35,
		/// <summary>
		///         Das Verzeichnis, das als allgemeines Repository für programmspezifische Daten verwendet wird, die von einem aktuellen Benutzer verwendet werden, der kein Roamingbenutzer ist.
		///       </summary>
		LocalApplicationData = 28,
		/// <summary>
		///         Das Verzeichnis, das als allgemeines Repository für Internetcookies verwendet wird.
		///       </summary>
		Cookies = 33,
		/// <summary>
		///         Der logische Desktop und nicht der physische Speicherort im Dateisystem.
		///       </summary>
		Desktop = 0,
		/// <summary>
		///         Das Verzeichnis, das als allgemeines Repository für die Favoriten des Benutzers verwendet wird.
		///       </summary>
		Favorites = 6,
		/// <summary>
		///         Das Verzeichnis, das als allgemeines Repository für die Internetverlaufselemente verwendet wird.
		///       </summary>
		History = 34,
		/// <summary>
		///         Das Verzeichnis, das als allgemeines Repository für temporäre Internetdateien verwendet wird.
		///       </summary>
		InternetCache = 0x20,
		/// <summary>
		///         Das Verzeichnis, das die Programmgruppen des Benutzers enthält.
		///       </summary>
		Programs = 2,
		/// <summary>
		///         Der Ordner Arbeitsplatz.
		///       </summary>
		MyComputer = 17,
		/// <summary>
		///         Der Ordner Eigene Musik.
		///       </summary>
		MyMusic = 13,
		/// <summary>
		///         Der Ordner Eigene Bilder.
		///       </summary>
		MyPictures = 39,
		/// <summary>
		///         Das Dateisystemverzeichnis, das als Repository für Videos dient, die zu einem Benutzer gehören.
		///           Hinzugefügt in .NET Framework 4.
		///       </summary>
		MyVideos = 14,
		/// <summary>
		///         Das Verzeichnis, das die vom Benutzer zuletzt verwendeten Dokumente enthält.
		///       </summary>
		Recent = 8,
		/// <summary>
		///         Das Verzeichnis, das die Elemente für das Menü "Senden an" enthält.
		///       </summary>
		SendTo = 9,
		/// <summary>
		///         Das Verzeichnis, das die Elemente für das Menü "Start" enthält.
		///       </summary>
		StartMenu = 11,
		/// <summary>
		///         Das Verzeichnis, das der Programmgruppe "Autostart" des Benutzers entspricht.
		///       </summary>
		Startup = 7,
		/// <summary>
		///         Das Verzeichnis "System".
		///       </summary>
		System = 37,
		/// <summary>
		///         Das Verzeichnis, das als allgemeines Repository für Dokumentvorlagen verwendet wird.
		///       </summary>
		Templates = 21,
		/// <summary>
		///         Das Verzeichnis, das für das physische Speichern von Dateiobjekten auf dem Desktop verwendet wird.
		///       </summary>
		DesktopDirectory = 0x10,
		/// <summary>
		///         Das Verzeichnis, das als allgemeines Repository für Dokumente verwendet wird.
		///       </summary>
		Personal = 5,
		/// <summary>
		///         Der Ordner Eigene Dateien.
		///       </summary>
		MyDocuments = 5,
		/// <summary>
		///         Das Verzeichnis für Programmdateien.
		///
		///         Auf einem nicht x86-System gibt die Übergabe von <see cref="F:System.Environment.SpecialFolder.ProgramFiles" /> an die <see cref="M:System.Environment.GetFolderPath(System.Environment.SpecialFolder)" />-Methode den Pfad für nicht x86-Programme zurück.
		///          Um das Dateiverzeichnis für x86 Programme auf einem nicht x86-System abzurufen, verwenden Sie den <see cref="F:System.Environment.SpecialFolder.ProgramFilesX86" />-Member.
		///       </summary>
		ProgramFiles = 38,
		/// <summary>
		///         Das Verzeichnis für Komponenten, die von mehreren Anwendungen gemeinsam genutzt werden.
		///
		///         Um das allgemeine Dateiverzeichnis für x86-Programme auf einem nicht x86-System abzurufen, verwenden Sie den <see cref="F:System.Environment.SpecialFolder.ProgramFilesX86" />-Member.
		///       </summary>
		CommonProgramFiles = 43,
		/// <summary>
		///         Das Dateisystemverzeichnis, das zum Speichern von Verwaltungstools für einen einzelnen Benutzer verwendet wird.
		///          Die Microsoft Management Console (MMC) speichert angepasste Konsolen in diesem Verzeichnis, das für den Benutzern von überall aus zugänglich ist.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		AdminTools = 48,
		/// <summary>
		///         Das Dateisystemverzeichnis, das als Stagingbereich für Dateien fungiert, die auf eine CD geschrieben werden sollen.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		CDBurning = 59,
		/// <summary>
		///         Das Dateisystemverzeichnis, das Verwaltungstools für alle Benutzer des Computers enthält.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		CommonAdminTools = 47,
		/// <summary>
		///         Das Dateisystemverzeichnis, das Dokumente enthält, die von allen Benutzern gemeinsam genutzt werden.
		///          Dieser besondere Ordner ist für Windows NT-Systeme, Windows 95- und Windows 98-Systeme mit installierter "Shfolder.dll" gültig.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		CommonDocuments = 46,
		/// <summary>
		///         Das Dateisystemverzeichnis, das als Repository für Musikdateien dient, die von allen Benutzern gemeinsam genutzt werden.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		CommonMusic = 53,
		/// <summary>
		///         Dieser Wert wird in Windows Vista für die Abwärtskompatibilität erkannt, aber der besondere Ordner selbst wird nicht mehr verwendet.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		CommonOemLinks = 58,
		/// <summary>
		///         Das Dateisystemverzeichnis, das als Repository für Bilddateien dient, die von allen Benutzern gemeinsam genutzt werden.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		CommonPictures = 54,
		/// <summary>
		///         Das Dateisystemverzeichnis, das die Programme und Ordner enthält, die im Menü Start für alle Benutzer angezeigt werden.
		///          Dieser besondere Ordner ist nur für Windows NT-Systeme gültig.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		CommonStartMenu = 22,
		/// <summary>
		///         Ein Ordner für Komponenten, die von mehreren Anwendungen gemeinsam verwendet werden.
		///          Dieser besondere Ordner nur für Windows NT-, Windows 2000- und Windows XP-Systeme gültig.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		CommonPrograms = 23,
		/// <summary>
		///         Das Dateisystemverzeichnis, das die Programme enthält, die im Ordner Startup für alle Benutzer angezeigt werden.
		///          Dieser besondere Ordner ist nur für Windows NT-Systeme gültig.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		CommonStartup = 24,
		/// <summary>
		///         Das Dateisystemverzeichnis, das Dateien und Ordner enthält, die auf dem Desktop für alle Benutzer angezeigt werden.
		///          Dieser besondere Ordner ist nur für Windows NT-Systeme gültig.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		CommonDesktopDirectory = 25,
		/// <summary>
		///         Das Dateisystemverzeichnis, das die für alle Benutzer verfügbaren Vorlagen enthält.
		///          Dieser besondere Ordner ist nur für Windows NT-Systeme gültig.
		///           Hinzugefügt in .NET Framework 4.
		///       </summary>
		CommonTemplates = 45,
		/// <summary>
		///         Das Dateisystemverzeichnis, das als Repository für Musikdateien dient, die von allen Benutzern gemeinsam genutzt werden.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		CommonVideos = 55,
		/// <summary>
		///         Ein virtueller Ordner, der Schriftarten enthält.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		Fonts = 20,
		/// <summary>
		///         Ein Dateisystemverzeichnis, das die Linkobjekte enthält, die im virtuellen Ordner Netzwerkumgebung vorhanden sein können.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		NetworkShortcuts = 19,
		/// <summary>
		///         Das Dateisystemverzeichnis, das die Linkobjekte enthält, die im virtuellen Ordner Drucker vorhanden sein können.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		PrinterShortcuts = 27,
		/// <summary>
		///         Der Profilordner des Benutzers.
		///          Anwendungen sollten keine Dateien oder Ordner auf dieser Ebene erstellen, sie sollten ihre Daten unter den Speicherorten ablegen, auf die von <see cref="F:System.Environment.SpecialFolder.ApplicationData" /> verwiesen wird.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		UserProfile = 40,
		/// <summary>
		///         Der Ordner Programme.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		CommonProgramFilesX86 = 44,
		/// <summary>
		///         Der x86-Ordner Programme.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		ProgramFilesX86 = 42,
		/// <summary>
		///         Das Dateisystemverzeichnis, das Ressourcendaten enthält.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		Resources = 56,
		/// <summary>
		///         Das Dateisystemverzeichnis, das lokalisierte Ressourcendaten enthält.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		LocalizedResources = 57,
		/// <summary>
		///         Der Windows-Ordner System.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		SystemX86 = 41,
		/// <summary>
		///         Das Windows-Verzeichnis oder SYSROOT.
		///          Dies entspricht den Umgebungsvariablen %windir% oder %SYSTEMROOT%.
		///          Hinzugefügt in .NET Framework 4.
		///       </summary>
		Windows = 36
        }
        *
        * System.DllNotFoundException
        * 
        * Konvertiert einen Basisdatentyp in einen anderen Basisdatentyp.
        * System.Convert
        * 
        * Stellt eine Anwendungsdomäne dar. Dies ist eine isolierte Umgebung, in der Programme ausgeführt werden.
        * System.AppDomain
        * 
        * Stellt eine verwaltete Entsprechung eines nicht verwalteten Hosts dar.
        * Der Aufrufer verfügt nicht über die ordnungsgemäßen Berechtigungen.
        * System.AppDomainManager
        * 
        * Enthält Informationen, um eine manifestbasierte Anwendung eindeutig zu identifizieren.
        * System.ApplicationId
        * 
        * Ruft den öffentlichen Schlüssel für die Anwendung ab.
        * PublicKeyToken
        * 
        * Microsoft.Win32.Registry
        * Microsoft.Win32.RegistryKey
        * Microsoft.Win32.RegistryKeyPermissionCheck
        * Microsoft.Win32.RegistryValueKind
        * Microsoft.Win32.RegistryView Registry64, Registry32
        * 
        * 
        * 
        */

        /// <summary>
        ///         Gibt das HRESULT für den letzten Fehler zurück, der durch einen mit <see cref="T:System.Runtime.InteropServices.Marshal" /> ausgeführten Win32-Code ausgelöst wurde.
        ///       </summary>
        /// <returns>
        ///         Das HRESULT für den letzten Win32-Fehlercode.
        ///       </returns>
        public static int VOSGetHRForLastWin32Error()
        {
            int lastWin32Error = Marshal.GetLastWin32Error();
            if ((lastWin32Error & 2147483648u) == 2147483648u)
            {
                return lastWin32Error;
            }
            return (lastWin32Error & 0xFFFF) | -2147024896;
        }


    } // end of class::VOSInternalBase

} // end of namespace:: Visual.Operation.System.Base
