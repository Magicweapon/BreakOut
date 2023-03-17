using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistenceManager : MonoBehaviour
{
    public List<PersistentClass> objectsToSave;

    public void OnEnable()
    {
        for (int i = 0; i < objectsToSave.Count; i++)
        {
            var scriptableObject = objectsToSave[i];
            scriptableObject.Load();
        }
    }

    public void OnDisable()
    {
        for (int i = 0; i < objectsToSave.Count; i++)
        {
            var scriptableObject = objectsToSave[i];
            scriptableObject.Save();
        }
    }
}
