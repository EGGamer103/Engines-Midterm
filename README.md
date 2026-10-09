I'm rather doubtful that I'll get much of anything from my practical submission, but it's only fair that I have some kind of explanations

first thing and the only solution I have totally functional is the singleton pattern, which I chose to use as a game manager mostly due to time constraint . 
the script is setup to verify the instance as the only existing instance or otherwise delete itself, and is set up to track the players points and the current game level for display on the screen (unimplemented).
by tracking the level it was also going to help with advancing to the next level via scene loading if time constraints or functionality didn't allow for my original level idea, though once again this went unimplemented.

the player movement script, which is the only script which I have almost entirely implemented (IsGrounded is presently a stand in function, original failed to work as intended), houses the shoot(bubble) function, 
which was intended to call to my factory (unfinished) to summon a bubble prefab and apply a velocity relative to the player speed (unimplemented).
original IsGrounded in case this is relevant: grounded = Physics2D.OverlapAreaAll(groundCheck.bounds.min, groundCheck.bounds.max, groundLayer).length > 0;

the factory function is just about entirely unimplemented, but the uses I'd planned for it were creating bubbles, enemies, and randomized levels. 
the enemy factory was going to spawn one of two enemy types (for scope reasons, though that didn't matter it would seem), 
- a basic grounded enemy with simple back and forth movement, no special characteristics, 
- and a grouped enemy like the first enemy shown in the bubble bobble video, which would have spawned in sets of three, and linked each ones movements to the one in front of it, 
my Idea for this was either to mirror the movements but delay each one by it's position in the line, or to have the front enemy draw a path to the player using a seeking behavior setup,
then have each of the three pathfind along that line.

finally, the first requirement which I put at the end for whatever reason, I have no scene or visuals because I prioritized finalizing the game functionality first, and unfortunately had no time.
