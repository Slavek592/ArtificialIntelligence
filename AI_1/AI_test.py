from AI_simple import *

ai = AI()
ai.learn(-20.0, 10.0)
ai.learn(-12.0, 5)
ai.learn(-6.0, 7.0)
ai.learn(0.0, 3.0)
ai.learn(12.0, 0.0)
ai.learn(22.0, -1)
ai.learn(30.0, -5.0)
ai.sure()
ai.print_say(3.0)

ai_2 = AI()
ai_2.learn(0.0, 15.0)
ai_2.learn(3.0, 10.0)
ai_2.learn(6.0, 12.0)
ai_2.learn(8.0, 8.0)
ai_2.learn(12.0, 5.0)
ai_2.learn(17.0, 4.0)
ai_2.learn(20.0, 0.0)
ai_2.sure()
ai_2.print_say(10.0)

ai_3 = AI()
ai_3.learn(0.0, 1.0)
ai_3.learn(3.0, 4.0)
ai_3.learn(6.0, 7.0)
ai_3.learn(8.0, 9.0)
ai_3.learn(12.0, 13.0)
ai_3.learn(17.0, 18.0)
ai_3.learn(20.0, 21.0)
ai_3.sure()
ai_3.print_say(10.0)
ai_3.print_test(10.0, 11.0)

