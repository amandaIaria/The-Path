using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PathController : MonoBehaviour {
	
	public Text text;
	private enum States {
						tree, path, knife, roots, tree_knife, knife_roots, tree_after, key_knife, tree_key, key_path, knife_path, 
						path_start, path_again, owl, owl_path, owl_path_left, owl_path_right, owl_path_end,
						crow, crow_path, crow_path_left, crow_path_right, crow_table, crow_shadow, crow_path_again, open_gate, end 
						};
	private States myState;	
	
	// Use this for initialization
	void Start () {
		myState = States.tree;
	}
	
	// Update is called once per frame
	void Update () {
		if 		(myState == States.tree)			{tree();}
		else if (myState == States.path)			{path();}
		else if (myState == States.knife)			{knife();}
		else if (myState == States.roots)			{roots();}
		else if (myState == States.tree_knife)		{tree_knife();}
		else if (myState == States.knife_roots)		{knife_roots();}
		else if (myState == States.tree_after)		{tree_after();}
		else if (myState == States.key_knife)		{key_knife();}
		else if (myState == States.tree_key)		{tree_key();}
		else if (myState == States.knife_path)		{knife_path();}
		else if (myState == States.key_path)		{key_path();}
		else if (myState == States.path_start)		{path_start();}
		else if (myState == States.owl)				{owl();} 
		else if (myState == States.owl_path)		{owl_path();}
		else if (myState == States.owl_path_left)	{owl_path_left();} 
		else if (myState == States.owl_path_right)	{owl_path_right();}
		else if (myState == States.owl_path_end)	{owl_path_end();}
		else if (myState == States.crow)			{crow();}
		else if (myState == States.path_again)		{path_again() ;}  
		else if (myState == States.crow_path)		{crow_path();}
		else if (myState == States.crow_path_left)	{crow_path_left();} 
		else if (myState == States.crow_path_right)	{crow_path_right() ;} 
		else if (myState == States.crow_table)		{crow_table();} 
		else if (myState == States.crow_shadow)		{crow_shadow();} 
		else if (myState == States.crow_path_again)	{crow_path_again() ;} 
		else if (myState == States.open_gate)		{open_gate();} 
		else if (myState == States.end)				{end();}
	}
	// --- functions for the path
	void end(){
		text.text = "A short text adventure by Amanda Iaria\n\n" +
					"[ Press space to start again ]";
		
		if(Input.GetKeyDown(KeyCode.Space)){
			myState = States.tree;
		}
	}
	void open_gate(){
		text.text = "As you open the gate, another strong gust of wind blows in your face. It forces you to turn your back and close your eyes. When it dies down " + 
					"and you can finally open your eyes again, you find that you are no longer in the dark forest, but in bed.\n\n" +
					"[ Press space to continue ]";
		
		if(Input.GetKeyDown(KeyCode.Space)){
			myState = States.end;
		}
	}
	void owl_path() {
		text.text = "As you walk down the path of the owl you notice how the shadows seem to deepen and the grass grows taller. \n" +
					"There's a bit of a breeze, and with it, a fog crawls in. You reach a fork in the path, left and right. " + 
					"As you look behind you the fog is almost solid, pushing you in a direction.\n\n" +
					"[ Press R for the Right path, L for the Left path ]";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.owl_path_right;
		}
		else if(Input.GetKeyDown(KeyCode.L)){
			myState = States.owl_path_left;
		}
	}
	void owl_path_left() {
		text.text = "As you take the left path you come realize the grass has grown over 10 feet, and too thick to walk through. " +
					"The shadows make it seem like they are reaching out to you, and the fog has shrouded the night sky. You walk left, then right, then left again. " +
					"The path starts to spiral inwards and until it just stops. You turn to walk back and there is nothing. Nothing but darkness. You turn forward, " +
					"and again nothing but darkness. As you close your eyes and hope for the best, a breeze blows across your face. \n\n" +
					"[ Press O to Open your eyes. ]";
		
		if(Input.GetKeyDown(KeyCode.O)){
			myState = States.owl_path_end;
		}
	}
	void owl_path_right() {
		text.text = "As you take the right path you come realize the grass has grown over 10 feet, and too thick to walk through. " +
					"The shadows make it seem like they are reaching out to you, and the fog has shrouded the night sky. You walk left, then right, then left again. " +
					"The path starts to spiral inwards and until it just stops. You turn to walk back and there is nothing. Nothing but darkness. You turn forward, " +
					"and again nothing but darkness. As you close your eyes and hope for the best, a breeze blows across your face. \n\n" +
					"[ Press O to Open your eyes. ]";
		
		if(Input.GetKeyDown(KeyCode.O)){
			myState = States.owl_path_end;
		}
	}
	void owl_path_end(){
		text.text = "As you open your eyes, you realize you are back at the fork in the path. The Owl and Crow sit on their respective places.\n\n " +
					"[ Press O to talk to the Owl, Press C to talk to the Crow ]";
		
		if(Input.GetKeyDown(KeyCode.O)){
			myState = States.owl; 
		}
		else if(Input.GetKeyDown(KeyCode.C)){
			myState = States.crow; 
		}
	}
	
	void owl(){
		text.text = "The owl puffs out their chest as you approach.\n\n'Who,\nAre,\nYou?'\n\n" +
					"'Does the journeyer know the truth or the lie? I have seen forever, there is nothing in the cold expanse of space." +
					"We can only hope for the heat death of the universe to comes and take us.'\n\n" +
					"[ Press R to Return. W to Walk the owl path. ]";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.path_again;
		}
		else if(Input.GetKeyDown(KeyCode.W)){
			myState = States.owl_path;
		}
	}
	void crow_path (){
		text.text = "As you walk down the path, the night sky brightens as the full moon illuminates the forest. Even though there aren't any leaves on the " +
					"trees, it still feels rather calming. Crickets and frogs start to 'sing,' and a gentle breeze sways the tree branches. But then you reach " +
					"another fork in the road. One going left, the other right. \n\n" +
					"[ Press R for the Right path, L for the Left path ]";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.crow_path_right;
		}
		else if(Input.GetKeyDown(KeyCode.L)){
			myState = States.crow_path_left;
		}
	}
	void crow_path_left (){
		text.text = "As you take the left path, the trees start to become more numerous. The wind picks up, and the trees creak. There is a bend in the path " +
					"that leans to the right, but at what seems like the end of the path you see a table. As you look behind you it seems like the shadows have become solid. \n\n " +
					"[ Press T to go to the Table, S go to the Shadow ]"; 
		
		if(Input.GetKeyDown(KeyCode.T)){
			myState = States.crow_table;
		}
		else if(Input.GetKeyDown(KeyCode.S)){
			myState = States.crow_shadow;
		}
	}
	void crow_path_right (){
		text.text = "As you take the right path, the trees start to become more numerous. The wind picks up, and the trees creak. There is a bend in the path " +
					"that leans to the left, but at what seems like the end of the path you see a table. As you look behind you it seems like the shadows have become solid. \n\n " +
					"[ Press T to go to the Table, S go to the Shadow ]"; 
		
		if(Input.GetKeyDown(KeyCode.T)){
			myState = States.crow_table;
		}
		else if(Input.GetKeyDown(KeyCode.S)){
			myState = States.crow_shadow;
		}
	}
	void crow_table (){
		text.text = "The table is just a simple wooden table, but there is a key. The key has the same symbol of a bird on it as the knife you have. \n\n" +
					"[ Press K to pick up the Key ]";
		
		if(Input.GetKeyDown(KeyCode.K)){
			myState = States.crow_path_again;
		}            
	}
	void crow_shadow (){
		text.text = "The shadow is like a solid wall and won't let you pass. \n\n" +
					"[ Press T to go to the Table ]";
		
		if(Input.GetKeyDown(KeyCode.T)){
			myState = States.crow_table;
		}
	}
	void crow_path_again (){
		text.text = "As you pick up the key, a strong breeze whips up. Sand is blown in your eyes. You rub them to get the sand out, and as you open your eyes you find yourself " +
					"at the of the forked path, in front of the gate. The owl and crow are still there, but the moon shines brightly. The gate seems to shimmer in the light. \n\n " +
					"[ Press G to use the key on the Gate ]";
		
		if(Input.GetKeyDown(KeyCode.G)){
			myState = States.open_gate;
		}
	}
	void crow(){
		text.text = "The Crow 'caas' as you approach, and you swear you can see them smile.\n" +
					"'This world is full of stories. Some are too fantastical. Some too cold for the warmest heat. " +
					"But do you know what I've seen? I've seen color's that could brighten the darkest of hearts. " +
					"There is life in the coldest regions of the universe, and a fire for creation.'\n\n" +
					"[ Press R to Return. W to Walk the crow path ]";
			
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.path_again;
		}
		else if(Input.GetKeyDown(KeyCode.W)){
			myState = States.crow_path;
		}
	}
	void path_again(){
		text.text = "You are at the beginning of the fork in the Path. As you look towards the tree you notice that the gate is locked again.\n" +
					"On the left, there's a Crow and the right an Owl. There's a signpost that says:" + 
					" 'I speak the truth, while I speak all lies.' \n\n" +
					"[ Press O to talk to the Owl, Press C to talk to the Crow ]";
		
		if(Input.GetKeyDown(KeyCode.O)){
			myState = States.owl; 
		}
		else if(Input.GetKeyDown(KeyCode.C)){
			myState = States.crow; 
		}
	}
	
	// ---- functions for each state --- at the tree
	void tree(){
		text.text = "There lies a tree in the middle of a clearing. " +
					"It was an old oak, hundreds of years old, with a strong trunk and limbs. " +
					"During the day many of animals would gather and rest beneath its mighty limbs. " +
					"But at night, that was a different story.\n\n" +
					"You wake up underneath the tree. The night sky is clear, and the moon is full. " + 
					"There are no sounds other than the swaying of the tree branches, but the shadows " +
					"feel like they are looking at you.\n\n" +
					"Around you are the roots, a knife, and a path ahead.\n\n"+
					"[ Press R to look at the Roots. K to take the Knife. P to go to the Path. ]";
			
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.roots;
		}
		else if(Input.GetKeyDown(KeyCode.K)){
			myState = States.knife;
		}
		else if(Input.GetKeyDown(KeyCode.P)){
			myState = States.path;
		}
	}
	void tree_after(){
		text.text = "You are at the Tree. The shadows dance in the distance.\n\n" +
					"[ Press R to look at the Roots. K to take the Knife. P to go to the Path. ]";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.roots;
		}
		else if(Input.GetKeyDown(KeyCode.K)){
			myState = States.knife;
		}
		else if(Input.GetKeyDown(KeyCode.P)){
			myState = States.path;
		}
	}
	void path(){
		text.text = "There is a locked gate blocking your way to the path. \n\n" +
					"[ Press R to Return ]";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.tree_after;
		}
	}
	void knife(){
		text.text = "There's a knife on the ground. It's an old hunter's knife with a bird on the handle. \n\n" +
					"[ Press R to Return, press T to Take the Knife ]";
		
		if(Input.GetKeyDown(KeyCode.T)){
			myState = States.tree_knife;
		}
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.tree_after;
		}
	}
	void roots(){
		text.text = "The roots stick out of the ground, but they're thick and strong. In the moonlight you see something glinting. \n\n" +
					"[ Press R to Return ]";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.tree_after;
		}
	}    
	void tree_knife(){
		text.text = "You're at the Tree. The knife in your hand seems to glow in the moonlight.\n\n" +
					"[ Press R to look at the Roots. P to go to the Path. ]";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.knife_roots;
		}
		else if(Input.GetKeyDown(KeyCode.P)){
			myState = States.knife_path;
		}
	}
	void knife_path(){
		text.text = "You have a knife, but it can't open the Gate.\n\n" +
					"[ Press R to Return ]";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.tree_knife;
		}
	}
	void knife_roots(){
		text.text = "The roots stick out of the ground, but they're thick and strong. In the moonlight you see something glinting. \n\n" +
					"[ Press T to Take ]";
		
		if(Input.GetKeyDown(KeyCode.T)){
			myState = States.key_knife;
		}
	}
	void key_knife(){
		text.text = "You dug out a key with the knife.\n\n"+
					"[ Press R to Return ]";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.tree_key;
		}
	}
	void tree_key(){
		text.text = "You're back at the tree, but with a key in hand.\n\n" +
					"[ Press P to go to the Path ]";
		
		if(Input.GetKeyDown(KeyCode.P)){
			myState = States.key_path;
		}
	}
	void key_path(){
		text.text = "You use the key to open the gate. \n\n"+
					"[Press W to Walk on the path]";
		
		if(Input.GetKeyDown(KeyCode.W)){
			myState = States.path_start; 
		}
	}
	void path_start(){
		text.text = "As you walk down the path you reach a fork. There are trees on each side. "+
					"On the left, there's a Crow and the right an Owl. On the side of the Owl, the path heads towards a plain. " +
					"While the crows side leads towards a dark leafless forest, where the trees look twisted. There's a signpost that says:" + 
					" 'I speak the truth, while I speak all lies. \n\n" +
					"[ Press O to talk to the Owl, Press C to talk to the Crow ]";
		
		if(Input.GetKeyDown(KeyCode.O)){
			myState = States.owl; 
		}
		else if(Input.GetKeyDown(KeyCode.C)){
			myState = States.crow; 
		}
	}
	
}
