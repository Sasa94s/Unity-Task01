using UnityEngine;
using System.Collections;

namespace ForgottenMines
{
	public class _Color : MonoBehaviour
	{
		private Color[] colors;
		private int ColorIndex { get; set; }
		public _Color()
		{
			ColorIndex = -1;		
			colors = new Color[10];
			colors[0]=Color.black;
			colors[1]=Color.blue;
			colors[2]=Color.cyan;
			colors[3]=Color.gray;
			colors[4]=Color.green;
			colors[5]=Color.grey;
			colors[6]=Color.magenta;
			colors[7]=Color.red;
			colors[8]=Color.white;
			colors[9]=Color.yellow;
		}
		public Color getNextColor()
		{
			if (ColorIndex == colors.Length-1)
				return colors [ColorIndex = 0];
			return colors [++ColorIndex];
		}
		public Color getColor()
		{
			return colors [ColorIndex];
		}
	}
}