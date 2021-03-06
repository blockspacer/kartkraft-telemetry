// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace KartKraft
{

using global::System;
using global::FlatBuffers;

/// Session data
public struct Session : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Session GetRootAsSession(ByteBuffer _bb) { return GetRootAsSession(_bb, new Session()); }
  public static Session GetRootAsSession(ByteBuffer _bb, Session obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Session __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int TotalTime { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TimeLeft { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TotalLaps { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public Vehicle? Vehicles(int j) { int o = __p.__offset(10); return o != 0 ? (Vehicle?)(new Vehicle()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int VehiclesLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Session> CreateSession(FlatBufferBuilder builder,
      int totalTime = 0,
      int timeLeft = 0,
      int totalLaps = 0,
      VectorOffset vehiclesOffset = default(VectorOffset)) {
    builder.StartObject(4);
    Session.AddVehicles(builder, vehiclesOffset);
    Session.AddTotalLaps(builder, totalLaps);
    Session.AddTimeLeft(builder, timeLeft);
    Session.AddTotalTime(builder, totalTime);
    return Session.EndSession(builder);
  }

  public static void StartSession(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddTotalTime(FlatBufferBuilder builder, int totalTime) { builder.AddInt(0, totalTime, 0); }
  public static void AddTimeLeft(FlatBufferBuilder builder, int timeLeft) { builder.AddInt(1, timeLeft, 0); }
  public static void AddTotalLaps(FlatBufferBuilder builder, int totalLaps) { builder.AddInt(2, totalLaps, 0); }
  public static void AddVehicles(FlatBufferBuilder builder, VectorOffset vehiclesOffset) { builder.AddOffset(3, vehiclesOffset.Value, 0); }
  public static VectorOffset CreateVehiclesVector(FlatBufferBuilder builder, Offset<Vehicle>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVehiclesVectorBlock(FlatBufferBuilder builder, Offset<Vehicle>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartVehiclesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Session> EndSession(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Session>(o);
  }
};


}
