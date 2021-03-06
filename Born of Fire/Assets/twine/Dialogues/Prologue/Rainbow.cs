﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: Rainbow.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @Rainbow: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
			VarDef("Fae", () => this.@Fae, val => this.@Fae = val);
		}

		public StoryVar @Fae;
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

	@Rainbow()
	{
		this.StartPassage = "Rainbow";

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
		passage12_Init();
		passage13_Init();
		passage14_Init();
		passage15_Init();
		passage16_Init();
		passage17_Init();
		passage18_Init();
		passage19_Init();
		passage20_Init();
		passage21_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Rainbow

	void passage1_Init()
	{
		this.Passages[@"Rainbow"] = new StoryPassage(@"Rainbow", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Are you Meredith Robinson?\"", "please", null);
		yield break;
	}


	// .............
	// #2: please

	void passage2_Init()
	{
		this.Passages[@"please"] = new StoryPassage(@"please", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("\"Please, call me Rainbow.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Okay, Meredith. What do you know about the fire?\"", "hostile", null);
		yield return lineBreak();
		yield return link("\"Okay, Rainbow. What do you know about the fire?\"", "friendly", null);
		yield break;
	}


	// .............
	// #3: hostile

	void passage3_Init()
	{
		this.Passages[@"hostile"] = new StoryPassage(@"hostile", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("The girl looks left and right, as if you might be talking to someone behind her.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Rainbow, what do you know about the fire?\"", "you", null);
		yield return lineBreak();
		yield return link("\"I'm not playing. Tell me what you know or get arrested.\"", "nothing", null);
		yield break;
	}


	// .............
	// #4: friendly

	void passage4_Init()
	{
		this.Passages[@"friendly"] = new StoryPassage(@"friendly", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("Rainbow softens a little, but she still seems tense.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("\"It wasn't us. Really. Sure, we broke in, but we would never start a fire!\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"If not you, then what?\"", "thing", null);
		yield break;
	}


	// .............
	// #5: you

	void passage5_Init()
	{
		this.Passages[@"you"] = new StoryPassage(@"you", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("\"You wouldn't believe me.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I've seen some crazy things in my time. Try me.\"", "friendly", null);
		yield break;
	}


	// .............
	// #6: nothing

	void passage6_Init()
	{
		this.Passages[@"nothing"] = new StoryPassage(@"nothing", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("\"I don't know anything. We went to the church, we left the church, the church caught on fire, the end.\"");
		yield break;
	}


	// .............
	// #7: thing

	void passage7_Init()
	{
		this.Passages[@"thing"] = new StoryPassage(@"thing", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("\"Well, okay. Before we left, we saw this... thing. At first we thought it might've been some kid, but it was too slender. It's skin was green and its teeth were pointed. And it had these big, shiny...\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Go on...\"", "\"Go on...\"", null);
		yield break;
	}


	// .............
	// #8: ""Go on...""

	void passage8_Init()
	{
		this.Passages[@"""Go on..."""] = new StoryPassage(@"""Go on...""", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("\"You were looking at me funny. You think I'm crazy, or high.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Are you?\"", "\"Are you?\"", null);
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I'm listening. Please, continue.\"", "\"I'm listening. Please, continue.\"", null);
		yield break;
	}


	// .............
	// #9: ""Are you?""

	void passage9_Init()
	{
		this.Passages[@"""Are you?"""] = new StoryPassage(@"""Are you?""", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("\"None of your buisiness! I saw what I saw.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"And what do you think it was that you saw.\"", "\"I'm listening. Please, continue.\"", null);
		yield break;
	}


	// .............
	// #10: ""I'm listening. Please, continue.""

	void passage10_Init()
	{
		this.Passages[@"""I'm listening. Please, continue."""] = new StoryPassage(@"""I'm listening. Please, continue.""", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("\"This thing had wings. Big, colorful wings. Like a butterfly's. I think it was... well, you know...\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"A fairy?\"", "\"A fairy?\"", null);
		yield return lineBreak();
		yield return lineBreak();
		Vars.Fae  = true;
		yield return lineBreak();
		yield return lineBreak();
		macros4.ExportVar("Fae");
		yield break;
	}


	// .............
	// #11: ""A fairy?""

	void passage11_Init()
	{
		this.Passages[@"""A fairy?"""] = new StoryPassage(@"""A fairy?""", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("The girl frown at you. ");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("\"See? You're not taking me seriously.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"But that's what you were going to say, wasn't it?\"", "maybee", null);
		yield break;
	}


	// .............
	// #12: maybee

	void passage12_Init()
	{
		this.Passages[@"maybee"] = new StoryPassage(@"maybee", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("The girl shrugs.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("\"It's what Tina would say. She's the one who studies mythologies. Anyway, you don't believe a word of this, do you?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Not a word.\"", "\"Not a word.\"", null);
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I believe you\"", "\"I believe you\"", null);
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I know you're not lying. If you were, you'd come up with a better lie. But that doesn't mean you're telling the truth.\"", "Good", null);
		yield break;
	}


	// .............
	// #13: Good

	void passage13_Init()
	{
		this.Passages[@"Good"] = new StoryPassage(@"Good", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return text("\"Your confidence is reassuring.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Extrodinary claims require extraordinary evidence. The truth will eventually reveal its self. All I can do is listen for when it does.\"", "Jonah", null);
		yield break;
	}


	// .............
	// #14: Jonah

	void passage14_Init()
	{
		this.Passages[@"Jonah"] = new StoryPassage(@"Jonah", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		yield return text("\"Jeez, you sound like Jonah. I don't need a lesson in philosopy today, Professor Detective sir.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Anyway, you say you saw this thing, and then what?\"", "bolted", null);
		yield break;
	}


	// .............
	// #15: ""Not a word.""

	void passage15_Init()
	{
		this.Passages[@"""Not a word."""] = new StoryPassage(@"""Not a word.""", new string[]{  }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return text("\"That's fine. I know I'm innocent.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Extrodinary claims require extraordinary evidence. The truth will eventually reveal its self. All I can do is listen for when it does.\"", "Jonah", null);
		yield break;
	}


	// .............
	// #16: ""I believe you""

	void passage16_Init()
	{
		this.Passages[@"""I believe you"""] = new StoryPassage(@"""I believe you""", new string[]{  }, passage16_Main);
	}

	IStoryThread passage16_Main()
	{
		yield return text("\"Then you're an idiot. I barely believe me. Between you and me I was REALLY-- out of it. Tired. When it all happened. Thing is, the others saw the same thing, even if they won't admit it to you.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Anyway, you say you saw this thing, and then what?\"", "bolted", null);
		yield break;
	}


	// .............
	// #17: bolted

	void passage17_Init()
	{
		this.Passages[@"bolted"] = new StoryPassage(@"bolted", new string[]{  }, passage17_Main);
	}

	IStoryThread passage17_Main()
	{
		yield return text("\"We tried telling it to leave us alone, but it just stood there. A few seconds later, the words were returned to us, like an echo, but louder. The things lips were moving as we heard it. It was freaky.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"What did you do?\"", "left", null);
		yield break;
	}


	// .............
	// #18: left

	void passage18_Init()
	{
		this.Passages[@"left"] = new StoryPassage(@"left", new string[]{  }, passage18_Main);
	}

	IStoryThread passage18_Main()
	{
		yield return text("\"What do you think? We left it the hell alone. Bolted out the front door like our lives depended on it.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"During your flight, do you think you could have left anything behind? Lit cigarettes, candles, or anything?\"", "LeftBehind", null);
		yield break;
	}


	// .............
	// #19: LeftBehind

	void passage19_Init()
	{
		this.Passages[@"LeftBehind"] = new StoryPassage(@"LeftBehind", new string[]{  }, passage19_Main);
	}

	IStoryThread passage19_Main()
	{
		yield return text("She shakes her head.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("\"No, we were all out of... cigarettes by that point. Everything was definitely out by that point.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Hmm... Wel, thanks for your cooperation. This has been an enlightening conversation.\"", "Umm", null);
		yield break;
	}


	// .............
	// #20: Umm

	void passage20_Init()
	{
		this.Passages[@"Umm"] = new StoryPassage(@"Umm", new string[]{  }, passage20_Main);
	}

	IStoryThread passage20_Main()
	{
		yield return text("\"Umm... you're welcome?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Back to the others.", "Back to the others.", null);
		yield break;
	}


	// .............
	// #21: Back to the others.

	void passage21_Init()
	{
		this.Passages[@"Back to the others."] = new StoryPassage(@"Back to the others.", new string[]{  }, passage21_Main);
	}

	IStoryThread passage21_Main()
	{
		macros3.ChangeScene("Fae_Park");
		yield break;
	}


}