using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

	void Awake()
	{

		List<Dictionary<string, object>> data = CSVReader.Read("PeriodicTable");

		for (var i = 0; i < data.Count; i++)
		{
			print("Name " + data[i]["name"] + " " +
				   "Symbol " + data[i]["Symbol"] + " " +
				   "AtomicNumber " + data[i]["atomic number"] + " " +
				   "AtomicMass " + data[i]["atomic mass"]);
		}

	}

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{

	}
}
