using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class PersistentClass : ScriptableObject
{
	public void Save(string fileName = null)
	{
		var bf = new BinaryFormatter();
		var file = File.Create(GetPath(fileName));
		var json = JsonUtility.ToJson(this);

		bf.Serialize(file, json);
		file.Close();
	}

	public virtual void Load(string fileName = null)
	{
		if (File.Exists(GetPath(fileName)))
		{
			var bf = new BinaryFormatter();
			var file = File.Open(GetPath(fileName), FileMode.Open);
			JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), this);
			file.Close();
		}
	}

	public string GetPath(string fileName = null)
	{
		var fileFullName = string.IsNullOrEmpty(fileName) ? "Persistent Class" : fileName;
		return string.Format("{0}/{1}.fex", Application.persistentDataPath, fileFullName);
	}
}