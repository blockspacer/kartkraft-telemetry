// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace KartKraft
{

using global::System;
using global::FlatBuffers;

public struct TrackConfig : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static TrackConfig GetRootAsTrackConfig(ByteBuffer _bb) { return GetRootAsTrackConfig(_bb, new TrackConfig()); }
  public static TrackConfig GetRootAsTrackConfig(ByteBuffer _bb, TrackConfig obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public TrackConfig __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span(4); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public byte NumSectors { get { int o = __p.__offset(6); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }

  public static Offset<TrackConfig> CreateTrackConfig(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      byte numSectors = 0) {
    builder.StartObject(2);
    TrackConfig.AddName(builder, nameOffset);
    TrackConfig.AddNumSectors(builder, numSectors);
    return TrackConfig.EndTrackConfig(builder);
  }

  public static void StartTrackConfig(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddNumSectors(FlatBufferBuilder builder, byte numSectors) { builder.AddByte(1, numSectors, 0); }
  public static Offset<TrackConfig> EndTrackConfig(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<TrackConfig>(o);
  }
};


}
