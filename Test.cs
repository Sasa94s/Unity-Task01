using UnityEngine;
using System.Collections;
using ForgottenMines;
using System.Collections.Generic;

public class Test : MonoBehaviour
{
		private _Color color = new _Color ();
		private _Shape[] shapes = new _Shape[3];
        private _Shape activeShape = null;
        private int x = 2, y = 6;
        // Use this for initialization
        void Start ()
		{
			shapes [0] = new _Shape (PrimitiveType.Cube);
			shapes [0].ShowShape ();
			shapes [1] = new _Shape (PrimitiveType.Sphere);
			CreateCone c = new CreateCone ();
			c.OnWizardCreate ();
			shapes [2] = new _Shape (c.getGameObject ());
		}
		// Update is called once per frame
		void Update ()
		{
			if (Input.GetKeyDown(KeyCode.A)) 
			{
				EditingShapes();
			}
			if (Input.GetKeyDown(KeyCode.D)) 
			{
				EditingShapes(WhosActive());
			}
		}
		void OnGUI()
		{
            if(GUI.Button(new Rect(350, 250, 70, 30), "Save"))
            {
                int ac = WhosActive();
                GameObject temp = Instantiate(shapes[ac].getGameObject()) as GameObject;
                _Shape saved = new _Shape(temp);
                saved.SetLastColor(color);
                if (x == 12)
                {
                    y -= 2;
                    saved.ChangePosition(new Vector3(x, y, 0));
                    x = 2;
                }
                else
                {
                    saved.ChangePosition(new Vector3(x, y, 0));
                    x += 2;
                }
                saved.ShowShape();
            }
        }
        private int WhosActive()
		{
			for (int i = 0; i < shapes.Length; i++) {
				if(shapes[i].IsActive()) 
				{
					activeShape=shapes[i];
					return i;
				}
			}
			return -1;
		}
		private void EditingShapes()
		{
			int tempindex=WhosActive ();
			if (tempindex != -1) 
			{
				shapes [tempindex].HideShape ();
				if (tempindex == shapes.Length - 1)
					tempindex = -1;
				shapes [tempindex + 1].SetLastColor (color);
				shapes [tempindex + 1].ShowShape ();
			}
		}
		private void EditingShapes(int activeIndex)
		{
			if (activeIndex != -1) 
			{
				shapes[activeIndex].ChangeColor(color);
			}
		}
}

