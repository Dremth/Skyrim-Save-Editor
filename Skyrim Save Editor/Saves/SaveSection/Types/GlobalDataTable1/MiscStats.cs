﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyrim_Save_Editor.Saves.SaveFields;

namespace Skyrim_Save_Editor.Saves.SaveSections {
	public class MiscStats : SaveSection {
		public SaveField<UInt32> type;
		public SaveField<UInt32> length;
		public SaveField<UInt32> miscStatsCount;
		public MiscStat[] statData;

		public MiscStats() {
			blockName = "Misc Stats";
			type = new SaveField<UInt32>("type");
			length = new SaveField<UInt32>("length");
			miscStatsCount = new SaveField<UInt32>("miscStatsCount");
		}

		public override void Load(SaveReader saveReader) {
			type.Value = saveReader.ReadUInt32();
			length.Value = saveReader.ReadUInt32();
			miscStatsCount.Value = saveReader.ReadUInt32();
			statData = saveReader.ReadMiscStat((int) miscStatsCount.Value);
		}

		public override SaveField[] GetFields() {
			SaveField[] fields = new SaveField[3] {
				type, length, miscStatsCount
			};
			fields = fields.Concat(statData).ToArray();
			return fields;
		}

		public override SaveSection[] GetSections() {
			return new SaveSection[0];
		}
	}
}
