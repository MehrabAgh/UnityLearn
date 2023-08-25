using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
	struct ProjectileStruct
	{
		public Vector3 Position;
		public Vector3 Velocity;
	}

	class ProjectileClass
	{
		public Vector3 Position;
		public Vector3 Velocity;
	}

	void Start()
	{
		const int count = 10000000;
		ProjectileStruct[] projectileStructs = new ProjectileStruct[count];
		ProjectileClass[] projectileClasses = new ProjectileClass[count];
		for (int i = 0; i < count; ++i)
		{
			projectileClasses[i] = new ProjectileClass();
		}
		Shuffle(projectileStructs);
		Shuffle(projectileClasses);

		System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
		for (int i = 0; i < count; ++i)
		{
			UpdateProjectile(ref projectileStructs[i], 0.5f);
		}
		long structTime = sw.ElapsedMilliseconds;

		sw.Reset();
		sw.Start();
		for (int i = 0; i < count; ++i)
		{
			UpdateProjectile(projectileClasses[i], 0.5f);
		}
		long classTime = sw.ElapsedMilliseconds;

		string report = string.Format(
			"Type,Time\n" +
			"Struct,{0}\n" +
			"Class,{1}\n",
			structTime,
			classTime
		);
		Debug.Log(report);
	}

	void UpdateProjectile(ref ProjectileStruct projectile, float time)
	{
		projectile.Position += projectile.Velocity * time;
	}

	void UpdateProjectile(ProjectileClass projectile, float time)
	{
		projectile.Position += projectile.Velocity * time;
	}

	public static void Shuffle<T>(T[] list)
	{
		System.Random random = new System.Random();
		for (int n = list.Length; n > 1;)
		{
			n--;
			int k = random.Next(n + 1);
			T value = list[k];
			list[k] = list[n];
			list[n] = value;
		}
	}
}

