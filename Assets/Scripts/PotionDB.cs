using UnityEngine;

public class PotionDB : MonoBehaviour
{
	public static PotionDB Instance
	{
		get
		{
			if( instance == null )
			{
				instance = Resources.Load<PotionDB>("PotionDB");
			}

			return instance;
		}
	}

	private static PotionDB instance;

	public Potion[] potions;
}
