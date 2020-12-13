﻿// © Anamnesis.
// Developed by W and A Walsh.
// Licensed under the MIT license.

namespace Anamnesis.Character
{
	using Anamnesis.GameData.Sheets;

	public class Animation : IJsonRow
	{
		public int Key { get; set; }
		public string Name { get; set; } = string.Empty;

		public string? Description => null;
	}
}
