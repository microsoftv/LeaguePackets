﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LeaguePackets.Game
{
    public class AddUnitPerceptionBubble : GamePacket // 0x23
    {
        public override GamePacketID ID => GamePacketID.AddUnitPerceptionBubble;
        public uint PerceptionBubbleType { get; set; }
        public uint ClientNetID { get; set; }
        public float Radius { get; set; }
        public uint UnitNetID { get; set; }
        public Vector3 Position { get; set; }
        public float TimeToLive { get; set; }
        public uint BubbleID { get; set; }
        public uint Flags { get; set; }

        protected override void ReadBody(ByteReader reader)
        {

            this.PerceptionBubbleType = reader.ReadUInt32();
            this.ClientNetID = reader.ReadUInt32();
            this.Radius = reader.ReadFloat();
            this.UnitNetID = reader.ReadUInt32();
            this.Position = reader.ReadVector3();
            this.TimeToLive = reader.ReadFloat();
            this.BubbleID = reader.ReadUInt32();
            this.Flags = reader.ReadUInt32();
        }
        protected override void WriteBody(ByteWriter writer)
        {
            writer.WriteUInt32(this.PerceptionBubbleType);
            writer.WriteUInt32(this.ClientNetID);
            writer.WriteFloat(this.Radius);
            writer.WriteUInt32(this.UnitNetID);
            writer.WriteVector3(this.Position);
            writer.WriteFloat(this.TimeToLive);
            writer.WriteUInt32(this.BubbleID);
            writer.WriteUInt32(this.Flags);
        }
    }
}