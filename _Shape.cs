//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;
namespace ForgottenMines
{
		public class _Shape : MonoBehaviour
		{
				private GameObject shape { get; set; }
				public _Shape (PrimitiveType ShapeType)
				{
					shape=GameObject.CreatePrimitive (ShapeType);
					this.shape.GetComponent<Renderer>().material.color = Color.black;
					HideShape ();
					shape.transform.position = new Vector3(0, 0.5F, 0);
				}
				public _Shape (GameObject ShapeType)
				{
					this.shape = GameObject.Instantiate (ShapeType, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
					GameObject.Destroy (ShapeType);
					this.shape.GetComponent<Renderer>().material.color = Color.black;
					HideShape ();
				}
                public void ChangePosition(Vector3 vec)
                {
                    shape.transform.position = vec;
                }
				public void ChangeColor(_Color color)
				{
					shape.GetComponent<Renderer>().material.color = color.getNextColor ();
				}
				public void SetLastColor(_Color color)
				{
					shape.GetComponent<Renderer>().material.color = color.getColor ();
				}
				public void HideShape()
				{
					shape.SetActive (false);
				}
				public void ShowShape()
				{
					shape.SetActive (true);
				}
				public bool IsActive()
				{
					return shape.activeInHierarchy;
				}
                public GameObject getGameObject()
                {
                    return shape;
                }
	}
}
