using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderManagement : MonoBehaviour
{
	[Header("Configurar en el editor")]
	public float radius;
	public bool keepOnScreen;

	[Header("Configuraciones dinámicas")]
	public bool isOnScreen = true;
	public float widthCamera, heightCamera;
	public bool outLeft, outRight, outUp, outDown;

	void Awake()
	{
		heightCamera = Camera.main.orthographicSize;
		widthCamera = Camera.main.aspect * heightCamera;
	}

	void LateUpdate()
	{
		Vector3 pos = transform.position;
		isOnScreen = true;
		outLeft = outRight = outUp = outDown = false;

		if (pos.x > widthCamera - radius)
		{
			pos.x = widthCamera - radius;
			outRight = true;
		}
		if (pos.x < -widthCamera + radius)
		{
			pos.x = -widthCamera + radius;
			outLeft = true;
		}
		if (pos.y > heightCamera - radius)
		{
			pos.y = heightCamera - radius;
			outUp = true;
		}
		if (pos.y < -heightCamera + radius)
		{
			pos.y = -heightCamera + radius;
			outDown = true;
		}

		isOnScreen = !(outLeft || outRight || outUp || outDown);

		if (keepOnScreen && !isOnScreen)
		{
			transform.position = pos;
			isOnScreen = true;
		}
	}

	private void OnDrawGizmos()
	{
		if (!Application.isPlaying) return;
		Vector3 borderSize = new Vector3(widthCamera * 2, heightCamera * 2, 0.1f);
		Gizmos.DrawWireCube(Vector3.zero, borderSize);
	}
}
