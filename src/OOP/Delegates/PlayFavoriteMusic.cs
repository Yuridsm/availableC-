﻿using System;

namespace lemure.OsOP.Delegates;

public class PlayFavoriteMusic
{
	public String play(string music)
	{
		if (music == "Ela vem".ToLower())
			return ("Ela vem - Biu do Piseiro...");
		return ("Não há música na playlist");
	}

	public static String next()
	{
		return ("Virgem - Biu do Piseiro...");
	}
}
