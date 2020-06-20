// Copyright (c) All contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

extern alias newmpcli;
using Benchmark.Serializers;

#pragma warning disable SA1649 // File name should match first type name

public class MsgPackCli : SerializerBase
{
	public override T Deserialize<T>(object input)
	{
		return MsgPackCliSerializerRepository<T>.V1.UnpackSingleObject((byte[])input);
	}

	public override object Serialize<T>(T input)
	{
		return MsgPackCliSerializerRepository<T>.V1.PackSingleObject(input);
	}
}
public class MsgPackCli_with_Get : SerializerBase
{
	public override T Deserialize<T>(object input)
	{
		return MsgPack.Serialization.MessagePackSerializer.Get<T>().UnpackSingleObject((byte[])input);
	}

	public override object Serialize<T>(T input)
	{
		return MsgPack.Serialization.MessagePackSerializer.Get<T>().PackSingleObject(input);
	}
}

internal static class MsgPackCliSerializerRepository<T>
{
	public static readonly MsgPack.Serialization.MessagePackSerializer<T> V1 = SampleSerializer.SerializationContext.GetSerializer<T>();

}
}
