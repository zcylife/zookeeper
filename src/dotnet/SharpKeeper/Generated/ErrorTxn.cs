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

namespace Org.Apache.Zookeeper.Txn
{
public class ErrorTxn : IRecord, IComparable 
{
  public ErrorTxn() {
  }
  public ErrorTxn(
  int err
) {
Err=err;
  }
  public int Err { get; set; } 
  public void Serialize(IOutputArchive a_, String tag) {
    a_.StartRecord(this,tag);
    a_.WriteInt(Err,"err");
    a_.EndRecord(this,tag);
  }
  public void Deserialize(IInputArchive a_, String tag) {
    a_.StartRecord(tag);
    Err=a_.ReadInt("err");
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
    a_.WriteInt(Err,"err");
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
    if (!(peer_ is ErrorTxn)) {
      throw new InvalidOperationException("Comparing different types of records.");
    }
    ErrorTxn peer = (ErrorTxn) peer_;
    int ret = 0;
    ret = (Err == peer.Err)? 0 :((Err<peer.Err)?-1:1);
    if (ret != 0) return ret;
     return ret;
  }
  public override bool Equals(object peer_) {
    if (!(peer_ is ErrorTxn)) {
      return false;
    }
    if (peer_ == this) {
      return true;
    }
    bool ret = false;
    ErrorTxn peer = (ErrorTxn)peer_;
    ret = (Err==peer.Err);
    if (!ret) return ret;
     return ret;
  }
  public override int GetHashCode() {
    int result = 17;
    int ret;
    ret = (int)Err;
    result = 37*result + ret;
    return result;
  }
  public static string Signature() {
    return "LErrorTxn(i)";
  }
}
}
