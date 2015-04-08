using UnityEngine;
using System.Collections;

public class InventoryManager : MonoBehaviour {

	public int startPos = 140;
	public int iconSize = 90;
	public  GameObject[] currentInventoryItems = new GameObject[0];
	public int iLength; //store the currentInventory's array length


	// Use this for initialization
	void Start () {
		//get a list of items with tag
		var iTems = GameObject.FindGameObjectsWithTag("QuestItem");
		var element = 0; //initialize a counter for ordering active objects
		//assign objects a position number for the currentinventory array
		for(int i=0;i<iTems.Length;i++){
		//only if current state is 1
			if(iTems[i].GetComponent<ObjectsState>().initialState==1){
				//assign the element number to the object
				iTems[i].GetComponent<ObjectsState>().iElement=element;
				element++;//increment the element
			}
			else//else it's initial state is 2,??, assign it to 100
				iTems[i].GetComponent<ObjectsState>().iElement=100;
			print("element@:"+iTems[i].GetComponent<ObjectsState>().iElement+"has object:"+iTems[i].GetComponent<ObjectsState>().name);

		}
		iLength=element; //save the number of elements, the number of  state1 object
		ItemOrderArray();
		InventoryPlacing();


	}
	
	// Update is called once per frame
	void Update () {

	}
	void ItemOrderArray(){
		//reinitialize currentinventory
		currentInventoryItems = new GameObject[iLength];
		var iTems = GameObject.FindGameObjectsWithTag("QuestItem");
		//create the nestloop to assign the elements
		//load the new array with state 1objects accdng to their iElement/order
		for(int e=0; e<iLength;e++){
			//currInvetory elements
			for(int i=0;i<iTems.Length;i++){
				//if match
				if(iTems[i].GetComponent<ObjectsState>().iElement==e){
					//add that object to the new array
					currentInventoryItems[e]=iTems[i];
					i=iTems.Length;//tell if done looking for that element number
					//reached the end
				}
			}
			print(currentInventoryItems[e]+"*"+e);//print new entry
		}//loop to look for next element , e
	}
	public void InventoryPlacing(){//arrange icons in inventory
		//
		var xPos = -startPos - iconSize/2;//adjust column offset startpos accrdng to icon
		var spacer = startPos  - iconSize-200;//calculate the spacer size

		var iLength = currentInventoryItems.Length;//length of the array
		//for loop
		for(int k=0; k<iLength;	k=k+0){
			var yPos = startPos - iconSize/2;
			currentInventoryItems[k].guiTexture.pixelInset = new Rect(xPos,yPos,iconSize,iconSize);
			//row 2
			yPos = yPos - iconSize - spacer;
			if(k+1<iLength)
				currentInventoryItems[k+1].guiTexture.pixelInset = new Rect(xPos,yPos,iconSize,iconSize);
			//row 3
			yPos = yPos - iconSize - spacer;
			if(k+2<iLength)
				currentInventoryItems[k+2].guiTexture.pixelInset = new Rect(xPos,yPos,iconSize,iconSize);
			xPos = xPos + iconSize + spacer;//update the column position for the next group
		}
	}
}
