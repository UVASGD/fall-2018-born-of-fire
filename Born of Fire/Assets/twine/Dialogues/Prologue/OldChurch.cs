﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: OldChurch.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @OldChurch: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
		}

	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;
	public readonly HOOK macros2;
	public readonly DialogueEnder macros3;
	public readonly GlobalVarMacros macros4;

	@OldChurch()
	{
		this.StartPassage = "Outside";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };
		macros2 = new HOOK() { Story = this };
		macros3 = new DialogueEnder() { Story = this };
		macros4 = new GlobalVarMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
		passage8_Init();
		passage9_Init();
		passage10_Init();
		passage11_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Outside

	void passage1_Init()
	{
		this.Passages[@"Outside"] = new StoryPassage(@"Outside", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("You come to the site of what used to be an old wooden chapel.");
		yield return lineBreak();
		yield return text("The site, barren and empty, awkwardly scars the town square.");
		yield return lineBreak();
		yield return text("Charred wooden panels haphazardly strew the ground,");
		yield return lineBreak();
		yield return text("leftovers of the wreckage.");
		yield return lineBreak();
		yield return link("Look around for clues.", "LookAround", null);
		yield return lineBreak();
		yield return link("Search underneath the rubble", "Underneath", null);
		yield return lineBreak();
		yield return link("Leave.", "End", null);
		yield break;
	}


	// .............
	// #2: LookAround

	void passage2_Init()
	{
		this.Passages[@"LookAround"] = new StoryPassage(@"LookAround", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("You have no idea what you are looking for, and quickly become confused.");
		yield return lineBreak();
		yield return link("Search underneath the rubble", "Underneath", null);
		yield break;
	}


	// .............
	// #3: Underneath

	void passage3_Init()
	{
		this.Passages[@"Underneath"] = new StoryPassage(@"Underneath", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("You toss a few scraps of wood to the side,");
		yield return lineBreak();
		yield return text("straining a bit for the larger panels and beams.");
		yield return lineBreak();
		yield return text("Underneath a particularly large blackened slab, you find a trap door,");
		yield return lineBreak();
		yield return text("outlined with grey where the ash decided to settle.");
		yield return lineBreak();
		yield return link("Open the trapdoor.", "Open", null);
		yield return lineBreak();
		yield return link("Leave.", "End", null);
		yield break;
	}


	// .............
	// #4: Open

	void passage4_Init()
	{
		this.Passages[@"Open"] = new StoryPassage(@"Open", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("The door creaks open, revealing a staircase descending into darkness.");
		yield return lineBreak();
		yield return text("If danger ever had a smell, the passageway reeks of it.");
		yield return lineBreak();
		yield return link("Go inside.", "GoInside", null);
		yield return lineBreak();
		yield return link("It's too risky.", "End", null);
		yield break;
	}


	// .............
	// #5: End

	void passage5_Init()
	{
		this.Passages[@"End"] = new StoryPassage(@"End", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		macros3.ChangeScene("Prologue_OverworldMenuSelect");
		yield break;
	}


	// .............
	// #6: GoInside

	void passage6_Init()
	{
		this.Passages[@"GoInside"] = new StoryPassage(@"GoInside", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("You step down carefully and come to flat ground after about twenty feet.");
		yield return lineBreak();
		yield return text("Ahead of you is nothing but black, and you have no idea how far");
		yield return lineBreak();
		yield return text("the tunnel stretches out for. You keep a lighter, but you are unsure how much and for how long it will be of use.");
		yield return lineBreak();
		yield return link("Ignite your lighter and forge onward.", "Forward", null);
		yield return lineBreak();
		yield return link("Nope the fuck out.", "End", null);
		yield break;
	}


	// .............
	// #7: Forward

	void passage7_Init()
	{
		this.Passages[@"Forward"] = new StoryPassage(@"Forward", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("You press onward and step to the cold stone floor.");
		yield return lineBreak();
		yield return text("The walls are rough and streaked with moss and mold.");
		yield return lineBreak();
		yield return text("You only have enough light to see one step in front of you.");
		yield return lineBreak();
		yield return text("Suddenly, with a puff, your lighter goes out.");
		yield return lineBreak();
		yield return text("Ahead of you, a light shines faintly. You look behind you and");
		yield return lineBreak();
		yield return text("the light from the beginning of the tunnel is nowhere to be seen.");
		yield return lineBreak();
		yield return link("Keep going forward.", "KeepGoing", null);
		yield return lineBreak();
		yield return link("Nope the fuck out.", "End", null);
		yield break;
	}


	// .............
	// #8: KeepGoing

	void passage8_Init()
	{
		this.Passages[@"KeepGoing"] = new StoryPassage(@"KeepGoing", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("As you approach the glow at the end of the tunnel,");
		yield return lineBreak();
		yield return text("you see shapes begin to take form.");
		yield return lineBreak();
		yield return text("A room, adorned in red drapery, walls lined with pots");
		yield return lineBreak();
		yield return text("of strange herbs and plants.");
		yield return lineBreak();
		yield return text("In the center, an ornate marble altar, upon which");
		yield return lineBreak();
		yield return text("rests a simple cloth doll.");
		yield return lineBreak();
		yield return link("Pick up the doll.", "PickUp", null);
		yield return lineBreak();
		yield return link("Nope the fuck out.", "Escape", null);
		yield break;
	}


	// .............
	// #9: PickUp

	void passage9_Init()
	{
		this.Passages[@"PickUp"] = new StoryPassage(@"PickUp", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("You step up slowly to the altar.");
		yield return lineBreak();
		yield return text("The air smells of sage and lemongrass.");
		yield return lineBreak();
		yield return text("Glancing over the doll, you notice it's yellowed clothes and");
		yield return lineBreak();
		yield return text("tattered texture. It must have been here for quite a while.");
		yield return lineBreak();
		yield return text("You reach out your hand and touch the doll on its head,");
		yield return lineBreak();
		yield return text("and everything");
		yield return lineBreak();
		yield return link("fades to white.", "Flashback", null);
		yield break;
	}


	// .............
	// #10: Escape

	void passage10_Init()
	{
		this.Passages[@"Escape"] = new StoryPassage(@"Escape", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("You turn around and prepare to run.");
		yield return lineBreak();
		yield return text("Whatever you've stumbled upon has seriously jarred your nerves.");
		yield return lineBreak();
		yield return text("You bolt down the hall, bouncing off the walls, unable to see anything.");
		yield return lineBreak();
		yield return text("Eventually, you break out into the day.");
		yield return lineBreak();
		yield return link("Take a breather.", "End", null);
		yield break;
	}


	// .............
	// #11: Flashback

	void passage11_Init()
	{
		this.Passages[@"Flashback"] = new StoryPassage(@"Flashback", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		macros3.ChangeScene("Dolls_FB1");
		yield break;
	}


}