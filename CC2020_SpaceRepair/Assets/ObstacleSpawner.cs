using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour
{

	public GameObject fish;
	public bool s_check;
	public GameObject[] spawner;
	Vector3 spawnV3;
	int rNum;
	public float spawnTime;
	float nextSpawnTime;
	public float addSTime;
	public float massTime;
	public float fMass;
	public float mass;
	float nextMassTime;
	// Use this for initialization
	void Start()
	{
		nextSpawnTime = Time.time + spawnTime;
		nextMassTime = Time.time + massTime;
	}

	// Update is called once per frame
	void Update()
	{

		if (s_check == true)
		{
			if (nextSpawnTime < Time.time)
			{
				nextSpawnTime = Time.time + spawnTime;
			}
		}

		if (Time.time >= nextMassTime)
		{
			fMass = fMass + mass;
			nextMassTime = nextMassTime + massTime;
		}

		if (fMass >= 3)
		{
			spawnTime = .50f;
		}
	}

	

	void MassAdd()
	{

		Debug.Log(gameObject.GetComponent<Rigidbody2D>().gravityScale);
	}
}
