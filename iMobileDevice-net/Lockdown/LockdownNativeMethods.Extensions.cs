// <copyright file="LockdownNativeMethods.cs" company="Quamotion">
// Copyright (c) 2016-2017 Quamotion. All rights reserved.
// </copyright>

namespace iMobileDevice.Lockdown
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public partial class LockdownNativeMethods
    {
        
        public static LockdownError lockdownd_query_type(LockdownClientHandle client, out string type)
        {
            System.Runtime.InteropServices.ICustomMarshaler typeMarshaler = NativeStringMarshaler.GetInstance(null);
            System.IntPtr typeNative = System.IntPtr.Zero;
            LockdownError returnValue = LockdownNativeMethods.lockdownd_query_type(client, out typeNative);
            type = ((string)typeMarshaler.MarshalNativeToManaged(typeNative));
            typeMarshaler.CleanUpNativeData(typeNative);
            return returnValue;
        }
        
        public static LockdownError lockdownd_start_session(LockdownClientHandle client, string hostId, out string sessionId, ref int sslEnabled)
        {
            System.Runtime.InteropServices.ICustomMarshaler sessionIdMarshaler = NativeStringMarshaler.GetInstance(null);
            System.IntPtr sessionIdNative = System.IntPtr.Zero;
            LockdownError returnValue = LockdownNativeMethods.lockdownd_start_session(client, hostId, out sessionIdNative, ref sslEnabled);
            sessionId = ((string)sessionIdMarshaler.MarshalNativeToManaged(sessionIdNative));
            sessionIdMarshaler.CleanUpNativeData(sessionIdNative);
            return returnValue;
        }
        
        public static LockdownError lockdownd_get_device_udid(LockdownClientHandle client, out string udid)
        {
            System.Runtime.InteropServices.ICustomMarshaler udidMarshaler = NativeStringMarshaler.GetInstance(null);
            System.IntPtr udidNative = System.IntPtr.Zero;
            LockdownError returnValue = LockdownNativeMethods.lockdownd_get_device_udid(client, out udidNative);
            udid = ((string)udidMarshaler.MarshalNativeToManaged(udidNative));
            udidMarshaler.CleanUpNativeData(udidNative);
            return returnValue;
        }
        
        public static LockdownError lockdownd_get_device_name(LockdownClientHandle client, out string deviceName)
        {
            System.Runtime.InteropServices.ICustomMarshaler deviceNameMarshaler = NativeStringMarshaler.GetInstance(null);
            System.IntPtr deviceNameNative = System.IntPtr.Zero;
            LockdownError returnValue = LockdownNativeMethods.lockdownd_get_device_name(client, out deviceNameNative);
            deviceName = ((string)deviceNameMarshaler.MarshalNativeToManaged(deviceNameNative));
            deviceNameMarshaler.CleanUpNativeData(deviceNameNative);
            return returnValue;
        }
        
        public static LockdownError lockdownd_get_sync_data_classes(LockdownClientHandle client, out System.Collections.ObjectModel.ReadOnlyCollection<string> classes, ref int count)
        {
            System.Runtime.InteropServices.ICustomMarshaler classesMarshaler = LockdownMarshaler.GetInstance(null);
            System.IntPtr classesNative = System.IntPtr.Zero;
            LockdownError returnValue = LockdownNativeMethods.lockdownd_get_sync_data_classes(client, out classesNative, ref count);
            classes = ((System.Collections.ObjectModel.ReadOnlyCollection<string>)classesMarshaler.MarshalNativeToManaged(classesNative));
            classesMarshaler.CleanUpNativeData(classesNative);
            return returnValue;
        }
    }
}