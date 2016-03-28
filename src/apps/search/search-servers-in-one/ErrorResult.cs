/**
 * Autogenerated by Thrift Compiler (@PACKAGE_VERSION@)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace dsn.app.search
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ErrorResult : TBase
  {
    private int _ErrorCode;

    public int ErrorCode
    {
      get
      {
        return _ErrorCode;
      }
      set
      {
        __isset.ErrorCode = true;
        this._ErrorCode = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool ErrorCode;
    }

    public ErrorResult() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I32) {
              ErrorCode = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("ErrorResult");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.ErrorCode) {
        field.Name = "ErrorCode";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ErrorCode);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("ErrorResult(");
      bool __first = true;
      if (__isset.ErrorCode) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ErrorCode: ");
        __sb.Append(ErrorCode);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}