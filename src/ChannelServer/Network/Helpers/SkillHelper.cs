﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.World;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;

namespace Melia.Channel.Network.Helpers
{
	public static class SkillHelper
	{
		/// <summary>
		/// Adds skill data to packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="skill"></param>
		public static void AddSkill(this Packet packet, Skill skill)
		{
			var properties = skill.Properties.GetAll();
			var propertiesSize = skill.Properties.Size;

			packet.PutLong(skill.ObjectId);
			packet.PutInt(skill.Id);
			packet.PutShort(propertiesSize);
			packet.PutEmptyBin(2); // alignment
			packet.PutInt(0);
			packet.PutShort(0);
			packet.PutEmptyBin(2); // alignment
			packet.AddProperties(properties);
		}
	}
}
