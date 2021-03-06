// Copyright (c) 2015 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GetCacheItemResponse.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetCacheItemResponse")]
  public partial class GetCacheItemResponse : global::ProtoBuf.IExtensible
  {
    public GetCacheItemResponse() {}
    

    private string _lockId = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"lockId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string lockId
    {
      get { return _lockId; }
      set { _lockId = value; }
    }

    private long _lockTicks = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"lockTicks", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long lockTicks
    {
      get { return _lockTicks; }
      set { _lockTicks = value; }
    }

    private int _priority = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int priority
    {
      get { return _priority; }
      set { _priority = value; }
    }

    private bool _hasExpired = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"hasExpired", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool hasExpired
    {
      get { return _hasExpired; }
      set { _hasExpired = value; }
    }

    private bool _needsResync = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"needsResync", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool needsResync
    {
      get { return _needsResync; }
      set { _needsResync = value; }
    }

    private long _absExp = default(long);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"absExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long absExp
    {
      get { return _absExp; }
      set { _absExp = value; }
    }

    private long _sldExp = default(long);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"sldExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long sldExp
    {
      get { return _sldExp; }
      set { _sldExp = value; }
    }

    private int _flag = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"flag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int flag
    {
      get { return _flag; }
      set { _flag = value; }
    }

    private long _creationTime = default(long);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"creationTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long creationTime
    {
      get { return _creationTime; }
      set { _creationTime = value; }
    }

    private long _lastModifiedTime = default(long);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"lastModifiedTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long lastModifiedTime
    {
      get { return _lastModifiedTime; }
      set { _lastModifiedTime = value; }
    }
    private readonly global::System.Collections.Generic.List<byte[]> _value = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(11, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> value
    {
      get { return _value; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
