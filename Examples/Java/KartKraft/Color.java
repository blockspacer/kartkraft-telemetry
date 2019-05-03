// automatically generated by the FlatBuffers compiler, do not modify

package KartKraft;

import java.nio.*;
import java.lang.*;
import java.util.*;
import com.google.flatbuffers.*;

@SuppressWarnings("unused")
/**
 * Useful generic color struct 
 */
public final class Color extends Struct {
  public void __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; }
  public Color __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public byte r() { return bb.get(bb_pos + 0); }
  public byte g() { return bb.get(bb_pos + 1); }
  public byte b() { return bb.get(bb_pos + 2); }

  public static int createColor(FlatBufferBuilder builder, byte r, byte g, byte b) {
    builder.prep(1, 3);
    builder.putByte(b);
    builder.putByte(g);
    builder.putByte(r);
    return builder.offset();
  }
}
