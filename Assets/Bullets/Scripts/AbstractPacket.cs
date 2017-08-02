﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public abstract class AbstractPacket : MonoBehaviour
	{
		public virtual float Damage { get { return 100; } }

		public virtual float Speed { get { return 10; } }

		public virtual float Mass { get { return 1; } }

		public abstract void DoAttack();

		public virtual void SetParams(RaycastHit hit, Vector3 direction) { }
	}
}