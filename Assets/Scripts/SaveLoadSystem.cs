using UnityEngine;

public static class SaveLoadSystem {


	public static void Save(string slotKey, SavingData data)
	{
		PlayerPrefs.SetInt(slotKey + "_level", data.level);
		PlayerPrefs.SetFloat(slotKey + "_positionX", data.positionX);
		PlayerPrefs.SetFloat(slotKey + "_positionY", data.positionY);
		PlayerPrefs.SetInt(slotKey + "_score", data.score);
		PlayerPrefs.SetFloat(slotKey + "_time", data.timeElapsed);
		PlayerPrefs.SetString(slotKey + "_playerName", data.playerName);
		
		PlayerPrefs.Save();
	}
	
	public static SavingData Load(string slotKey)
	{
		SavingData data = new SavingData();
		
		data.level = PlayerPrefs.GetInt(slotKey + "_level");
		data.positionX = PlayerPrefs.GetFloat(slotKey + "_positionX");
		data.positionY = PlayerPrefs.GetFloat(slotKey + "_positionY");
		data.score = PlayerPrefs.GetInt(slotKey + "_score");
		data.timeElapsed = PlayerPrefs.GetFloat(slotKey + "_time");
		data.playerName = PlayerPrefs.GetString(slotKey + "_playerName");

		return data;
	}

	public static void DeleteSlot(string slotKey)
	{
		PlayerPrefs.DeleteKey(slotKey + "_level");
		PlayerPrefs.DeleteKey(slotKey + "_positionX");
		PlayerPrefs.DeleteKey(slotKey + "_positionY");
		PlayerPrefs.DeleteKey(slotKey + "_score");
		PlayerPrefs.DeleteKey(slotKey + "_time");
		PlayerPrefs.DeleteKey(slotKey + "_playerName");
	}
	
	public static void DeleteAllSlot()
	{
		PlayerPrefs.DeleteAll();
	}
	
	public static bool HasSlot(string slotKey)
	{
		return PlayerPrefs.HasKey(slotKey + "_level");
	}
	
}


public class SavingData
{
	public int level;
	public float positionX;
	public float positionY;
	public int score;
	public float timeElapsed;
	public string playerName;
}
