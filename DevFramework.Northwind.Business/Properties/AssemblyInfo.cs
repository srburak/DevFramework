﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DevFramework.Core.Aspects.Postsharp.ExceptionAspects;
using DevFramework.Core.Aspects.Postsharp.LogAspects;
using DevFramework.Core.Aspects.Postsharp.PerformanceAspects;
using DevFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("DevFramework.Northwind.Business")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("DevFramework.Northwind.Business")]
[assembly: AssemblyCopyright("Copyright ©  2024")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: LogAspect(typeof(FileLogger),AttributeTargetTypes = "DevFramework.Northwind.Business.Concrete.Managers.*")]
[assembly: LogAspect(typeof(DatabaseLogger), AttributeTargetTypes = "DevFramework.Northwind.Business.Concrete.Managers.*")]
[assembly: ExceptionLogAspect(typeof(FileLogger), AttributeTargetMembers = "DevFramework.Northwind.Business.Concrete.Managers.*")]
[assembly: ExceptionLogAspect(typeof(DatabaseLogger), AttributeTargetMembers = "DevFramework.Northwind.Business.Concrete.Managers.*")]
[assembly: PerformanceCounterAspect(AttributeTargetMembers = "DevFramework.Northwind.Business.Concrete.Managers.*")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("a5ae5c73-576b-4faf-b8f2-4216f3495840")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
