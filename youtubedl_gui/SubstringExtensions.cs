namespace youtubedl_gui {
	static class SubstringExtensions {
		/// <summary>
		/// Get substring in a string between 2 substring <paramref name="from"/> and <paramref name="to"/>
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		public static string Between(this string value, string from, string to) {
			int posA = value.IndexOf(from);
			int posB = value.LastIndexOf(to);
			if (posA == -1) {
				return "";
			}
			if (posB == -1) {
				return "";
			}
			int adjustedPosA = posA + from.Length;
			if (adjustedPosA >= posB) {
				return "";
			}
			return value.Substring(adjustedPosA, posB - adjustedPosA);
		}

		/// <summary>
		/// Get substring between a substring <paramref name="to"/>
		/// </summary>
		/// <param name="to"></param>
		public static string Before(this string value, string to) {
			int posA = value.IndexOf(to);
			if (posA == -1) {
				return "";
			}
			return value.Substring(0, posA);
		}

		/// <summary>
		/// Get substring after a substring <paramref name="from"/>
		/// </summary>
		/// <param name="from"></param>
		public static string After(this string value, string from) {
			int posA = value.LastIndexOf(from);
			if (posA == -1) {
				return "";
			}
			int adjustedPosA = posA + from.Length;
			if (adjustedPosA >= value.Length) {
				return "";
			}
			return value.Substring(adjustedPosA);
		}
	}
}
