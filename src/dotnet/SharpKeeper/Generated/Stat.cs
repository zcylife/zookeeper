// File generated by hadoop record compiler. Do not edit.
/**
* Licensed to the Apache Software Foundation (ASF) under one
* or more contributor license agreements.  See the NOTICE file
* distributed with this work for additional information
* regarding copyright ownership.  The ASF licenses this file
* to you under the Apache License, Version 2.0 (the
* "License"); you may not use this file except in compliance
* with the License.  You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using Org.Apache.Jute;

namespace Org.Apache.Zookeeper.Data
{
public class Stat : IRecord, IComparable 
{
  public Stat() {
  }
  public Stat(
  long czxid
,
  long mzxid
,
  long ctime
,
  long mtime
,
  int version
,
  int cversion
,
  int aversion
,
  long ephemeralOwner
,
  int dataLength
,
  int numChildren
,
  long pzxid
) {
Czxid=czxid;
Mzxid=mzxid;
Ctime=ctime;
Mtime=mtime;
Version=version;
Cversion=cversion;
Aversion=aversion;
EphemeralOwner=ephemeralOwner;
DataLength=dataLength;
NumChildren=numChildren;
Pzxid=pzxid;
  }
  public long Czxid { get; set; } 
  public long Mzxid { get; set; } 
  public long Ctime { get; set; } 
  public long Mtime { get; set; } 
  public int Version { get; set; } 
  public int Cversion { get; set; } 
  public int Aversion { get; set; } 
  public long EphemeralOwner { get; set; } 
  public int DataLength { get; set; } 
  public int NumChildren { get; set; } 
  public long Pzxid { get; set; } 
  public void Serialize(IOutputArchive a_, String tag) {
    a_.StartRecord(this,tag);
    a_.WriteLong(Czxid,"czxid");
    a_.WriteLong(Mzxid,"mzxid");
    a_.WriteLong(Ctime,"ctime");
    a_.WriteLong(Mtime,"mtime");
    a_.WriteInt(Version,"version");
    a_.WriteInt(Cversion,"cversion");
    a_.WriteInt(Aversion,"aversion");
    a_.WriteLong(EphemeralOwner,"ephemeralOwner");
    a_.WriteInt(DataLength,"dataLength");
    a_.WriteInt(NumChildren,"numChildren");
    a_.WriteLong(Pzxid,"pzxid");
    a_.EndRecord(this,tag);
  }
  public void Deserialize(IInputArchive a_, String tag) {
    a_.StartRecord(tag);
    Czxid=a_.ReadLong("czxid");
    Mzxid=a_.ReadLong("mzxid");
    Ctime=a_.ReadLong("ctime");
    Mtime=a_.ReadLong("mtime");
    Version=a_.ReadInt("version");
    Cversion=a_.ReadInt("cversion");
    Aversion=a_.ReadInt("aversion");
    EphemeralOwner=a_.ReadLong("ephemeralOwner");
    DataLength=a_.ReadInt("dataLength");
    NumChildren=a_.ReadInt("numChildren");
    Pzxid=a_.ReadLong("pzxid");
    a_.EndRecord(tag);
}
  public override String ToString() {
    try {
      System.IO.MemoryStream ms = new System.IO.MemoryStream();
      System.IO.BinaryWriter writer =
        new System.IO.BinaryWriter(ms);
      BinaryOutputArchive a_ = 
        new BinaryOutputArchive(writer);
      a_.StartRecord(this,"");
    a_.WriteLong(Czxid,"czxid");
    a_.WriteLong(Mzxid,"mzxid");
    a_.WriteLong(Ctime,"ctime");
    a_.WriteLong(Mtime,"mtime");
    a_.WriteInt(Version,"version");
    a_.WriteInt(Cversion,"cversion");
    a_.WriteInt(Aversion,"aversion");
    a_.WriteLong(EphemeralOwner,"ephemeralOwner");
    a_.WriteInt(DataLength,"dataLength");
    a_.WriteInt(NumChildren,"numChildren");
    a_.WriteLong(Pzxid,"pzxid");
      a_.EndRecord(this,"");
      ms.Position = 0;
      return System.Text.Encoding.UTF8.GetString(ms.ToArray());
    } catch (Exception ex) {
      Console.WriteLine(ex.StackTrace);
    }
    return "ERROR";
  }
  public void Write(System.IO.BinaryWriter writer) {
    BinaryOutputArchive archive = new BinaryOutputArchive(writer);
    Serialize(archive, "");
  }
  public void ReadFields(System.IO.BinaryReader reader) {
    BinaryInputArchive archive = new BinaryInputArchive(reader);
    Deserialize(archive, "");
  }
  public int CompareTo (object peer_) {
    if (!(peer_ is Stat)) {
      throw new InvalidOperationException("Comparing different types of records.");
    }
    Stat peer = (Stat) peer_;
    int ret = 0;
    ret = (Czxid == peer.Czxid)? 0 :((Czxid<peer.Czxid)?-1:1);
    if (ret != 0) return ret;
    ret = (Mzxid == peer.Mzxid)? 0 :((Mzxid<peer.Mzxid)?-1:1);
    if (ret != 0) return ret;
    ret = (Ctime == peer.Ctime)? 0 :((Ctime<peer.Ctime)?-1:1);
    if (ret != 0) return ret;
    ret = (Mtime == peer.Mtime)? 0 :((Mtime<peer.Mtime)?-1:1);
    if (ret != 0) return ret;
    ret = (Version == peer.Version)? 0 :((Version<peer.Version)?-1:1);
    if (ret != 0) return ret;
    ret = (Cversion == peer.Cversion)? 0 :((Cversion<peer.Cversion)?-1:1);
    if (ret != 0) return ret;
    ret = (Aversion == peer.Aversion)? 0 :((Aversion<peer.Aversion)?-1:1);
    if (ret != 0) return ret;
    ret = (EphemeralOwner == peer.EphemeralOwner)? 0 :((EphemeralOwner<peer.EphemeralOwner)?-1:1);
    if (ret != 0) return ret;
    ret = (DataLength == peer.DataLength)? 0 :((DataLength<peer.DataLength)?-1:1);
    if (ret != 0) return ret;
    ret = (NumChildren == peer.NumChildren)? 0 :((NumChildren<peer.NumChildren)?-1:1);
    if (ret != 0) return ret;
    ret = (Pzxid == peer.Pzxid)? 0 :((Pzxid<peer.Pzxid)?-1:1);
    if (ret != 0) return ret;
     return ret;
  }
  public override bool Equals(object peer_) {
    if (!(peer_ is Stat)) {
      return false;
    }
    if (peer_ == this) {
      return true;
    }
    bool ret = false;
    Stat peer = (Stat)peer_;
    ret = (Czxid==peer.Czxid);
    if (!ret) return ret;
    ret = (Mzxid==peer.Mzxid);
    if (!ret) return ret;
    ret = (Ctime==peer.Ctime);
    if (!ret) return ret;
    ret = (Mtime==peer.Mtime);
    if (!ret) return ret;
    ret = (Version==peer.Version);
    if (!ret) return ret;
    ret = (Cversion==peer.Cversion);
    if (!ret) return ret;
    ret = (Aversion==peer.Aversion);
    if (!ret) return ret;
    ret = (EphemeralOwner==peer.EphemeralOwner);
    if (!ret) return ret;
    ret = (DataLength==peer.DataLength);
    if (!ret) return ret;
    ret = (NumChildren==peer.NumChildren);
    if (!ret) return ret;
    ret = (Pzxid==peer.Pzxid);
    if (!ret) return ret;
     return ret;
  }
  public override int GetHashCode() {
    int result = 17;
    int ret;
    ret = (int)Czxid;
    result = 37*result + ret;
    ret = (int)Mzxid;
    result = 37*result + ret;
    ret = (int)Ctime;
    result = 37*result + ret;
    ret = (int)Mtime;
    result = 37*result + ret;
    ret = (int)Version;
    result = 37*result + ret;
    ret = (int)Cversion;
    result = 37*result + ret;
    ret = (int)Aversion;
    result = 37*result + ret;
    ret = (int)EphemeralOwner;
    result = 37*result + ret;
    ret = (int)DataLength;
    result = 37*result + ret;
    ret = (int)NumChildren;
    result = 37*result + ret;
    ret = (int)Pzxid;
    result = 37*result + ret;
    return result;
  }
  public static string Signature() {
    return "LStat(lllliiiliil)";
  }
}
}
