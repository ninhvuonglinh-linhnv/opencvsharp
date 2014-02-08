﻿/*
 * (C) 2008-2014 shimat
 * This code is licenced under the LGPL.
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using OpenCvSharp;
using OpenCvSharp.Utilities;

#pragma warning disable 1591

namespace OpenCvSharp.CPlusPlus.Prototype
{
    /// <summary>
    /// P/Invoke methods of OpenCV 2.x C++ interface
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    internal static partial class CppInvoke
    {
        #region core
        #region Algorithm

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Algorithm_new();
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Algorithm_delete(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Algorithm_name(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] StringBuilder buf);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Algorithm_sizeof();

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Algorithm_getInt(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern double core_Algorithm_getDouble(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool core_Algorithm_getBool(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Algorithm_getString(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] StringBuilder buf);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Algorithm_getMat(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name, out IntPtr outMat);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Algorithm_getMatVector(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name, out IntPtr outVec);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Algorithm_getAlgorithm(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Algorithm_setInt(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name, int value);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Algorithm_setDouble(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name, double value);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Algorithm_setBool(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.Bool)] bool value);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Algorithm_setString(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Algorithm_setMat(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name, IntPtr value);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Algorithm_setMatVector(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name, IntPtr value);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Algorithm_setAlgorithm(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string name, IntPtr value);
        #endregion
        #region MatND
        #region Init & Disposal
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int MatND_sizeof();
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MatND_delete(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MatND_new1();
        #endregion
        #region Fields
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int MatND_flags_get(IntPtr src);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int MatND_dims_get(IntPtr src);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MatND_refcount_get(IntPtr src);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MatND_data_get(IntPtr src);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MatND_datastart_get(IntPtr src);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MatND_dataend_get(IntPtr src);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MatND_size_get(IntPtr src);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MatND_step_get(IntPtr src);
        #endregion
        #region Operators
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MatND_opRange(IntPtr src, CvSlice[] ranges, IntPtr dst);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MatND_opMat(IntPtr src, IntPtr dst);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MatND_opCvMatND(IntPtr src, IntPtr dst);
        #endregion
        #region Methods
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MatND_copyTo1(IntPtr src, IntPtr m);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MatND_copyTo2(IntPtr src, IntPtr m, IntPtr mask);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MatND_convertTo(IntPtr src, IntPtr m, [MarshalAs(UnmanagedType.I4)] MatrixType rtype, double alpha, double beta);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MatND_setTo(IntPtr src, CvScalar s, IntPtr mask, IntPtr dst);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MatND_reshape(IntPtr src, int newCn, int newNdims, [MarshalAs(UnmanagedType.LPArray)] int[] newsz, IntPtr dst);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MatND_ptr1(IntPtr src, int i0);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MatND_ptr2(IntPtr src, int i0, int i1);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MatND_ptr3(IntPtr src, int i0, int i1, int i2);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MatND_ptr4(IntPtr src, [MarshalAs(UnmanagedType.LPArray)] int[] idx);
        #endregion
        #endregion
        #region Array Operations
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_abs1(IntPtr src, IntPtr dst);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_add1(IntPtr a, IntPtr b, IntPtr c, IntPtr mask);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_add2(IntPtr a, CvScalar s, IntPtr c, IntPtr mask);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_subtract1(IntPtr a, IntPtr b, IntPtr c, IntPtr mask);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_subtract2(IntPtr a, CvScalar s, IntPtr c, IntPtr mask);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_subtract3(CvScalar s, IntPtr a, IntPtr c, IntPtr mask);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_multiply(IntPtr a, IntPtr b, IntPtr c, double scale);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_divide1(IntPtr a, IntPtr b, IntPtr c, double scale);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_divide2(double scale, IntPtr b, IntPtr c);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_convertScaleAbs(IntPtr src, IntPtr dst, double alpha, double beta);
        #endregion

        #region Drawing
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_line(IntPtr img, Point pt1, Point pt2, CvScalar color, int thickness, int lineType, int shift);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_rectangle1")]
        public static extern void core_rectangle(IntPtr img, Point pt1, Point pt2, CvScalar color, int thickness, int lineType, int shift);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_rectangle2")]
        public static extern void core_rectangle(IntPtr img, Rect rect, CvScalar color, int thickness, int lineType, int shift);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_circle(IntPtr img, Point center, int radius, CvScalar color, int thickness, int lineType, int shift);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_ellipse1")]
        public static extern void core_ellipse(IntPtr img, Point center, Size axes,
            double angle, double startAngle, double endAngle, CvScalar color, int thickness, int lineType, int shift);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_ellipse2")]
        public static extern void core_ellipse(IntPtr img, RotatedRect box, CvScalar color, int thickness, int lineType);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_fillConvexPoly(IntPtr img, Point[] pts, int npts, CvScalar color, int lineType, int shift);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_fillPoly(IntPtr img, IntPtr[] pts, int[] npts, int ncontours,
            CvScalar color, int lineType, int shift, Point offset);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_polylines(IntPtr img, IntPtr[] pts, int[] npts,
            int ncontours, int isClosed, CvScalar color, int thickness, int lineType, int shift);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_clipLine1")]
        public static extern int core_clipLine(Size imgSize, ref Point pt1, ref Point pt2);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_clipLine2")]
        public static extern int core_clipLine(Rect imgRect, ref Point pt1, ref Point pt2);

        #endregion

        #region Miscellaneous
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_setNumThreads(int nthreads);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_getNumThreads();
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_getThreadNum();
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_getBuildInformation([MarshalAs(UnmanagedType.LPStr)] StringBuilder buf, uint maxLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern long core_getTickCount();
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern double core_getTickFrequency();
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern long core_getCPUTickCount();
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_checkHardwareSupport([MarshalAs(UnmanagedType.I4)] HardwareSupport feature);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_getNumberOfCPUs();
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_fastMalloc(IntPtr bufSize);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_fastFree(IntPtr ptr);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_setUseOptimized(int onoff);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_useOptimized();

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_cvarrToMat(IntPtr arr, int copyData, int allowND, int coiMode);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_extractImageCOI(IntPtr arr, IntPtr coiimg, int coi);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_insertImageCOI(IntPtr coiimg, IntPtr arr, int coi);
        #endregion
        #endregion
    }
}