/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class XcapMessage : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XcapMessage(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(XcapMessage obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~XcapMessage() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_XcapMessage(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public XcapMessage() : this(tinyWRAPPINVOKE.new_XcapMessage(), true) {
  }

  public short getCode() {
    short ret = tinyWRAPPINVOKE.XcapMessage_getCode(swigCPtr);
    return ret;
  }

  public string getPhrase() {
    string ret = tinyWRAPPINVOKE.XcapMessage_getPhrase(swigCPtr);
    return ret;
  }

  public string getXcapHeaderValue(string name, uint index) {
    string ret = tinyWRAPPINVOKE.XcapMessage_getXcapHeaderValue__SWIG_0(swigCPtr, name, index);
    return ret;
  }

  public string getXcapHeaderValue(string name) {
    string ret = tinyWRAPPINVOKE.XcapMessage_getXcapHeaderValue__SWIG_1(swigCPtr, name);
    return ret;
  }

  public string getXcapHeaderParamValue(string name, string param, uint index) {
    string ret = tinyWRAPPINVOKE.XcapMessage_getXcapHeaderParamValue__SWIG_0(swigCPtr, name, param, index);
    return ret;
  }

  public string getXcapHeaderParamValue(string name, string param) {
    string ret = tinyWRAPPINVOKE.XcapMessage_getXcapHeaderParamValue__SWIG_1(swigCPtr, name, param);
    return ret;
  }

  public uint getXcapContentLength() {
    uint ret = tinyWRAPPINVOKE.XcapMessage_getXcapContentLength(swigCPtr);
    return ret;
  }

  public uint getXcapContent(IntPtr output, uint maxsize) {
    uint ret = tinyWRAPPINVOKE.XcapMessage_getXcapContent(swigCPtr, output, maxsize);
    return ret;
  }

}

}
