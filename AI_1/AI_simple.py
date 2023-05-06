class AI:
    def __init__(self):
        self.a = 0
        self.b = 0
        self.memory = {}

    def count(self, how_sure=1):
        best_sum = -1.0
        a = self.a
        b = self.b
        to_exit = 0
        for i in range(10 * how_sure):
            vert_sum = 0.0
            new_sum = 0.0
            min_data = min(self.memory.keys())
            max_data = max(self.memory.keys())
            mid_data = (max_data + min_data) / 2
            difference = max_data - mid_data
            if min_data == max_data:
                difference = 1
            hor_sum = 0.0
            for data in self.memory.keys():
                r = data * a + b - self.memory[data]
                new_sum += r ** 2
                vert_sum += r
                position = (data - mid_data) / difference
                hor_sum += r ** 2 * position
            if (new_sum < best_sum) or (best_sum < 0):
                to_exit = 0
                self.a = a
                self.b = b
                a += hor_sum / 100 / len(self.memory.keys())
                b -= vert_sum / 100 / len(self.memory.keys())
                best_sum = new_sum
            elif to_exit == 0:
                b = self.b
                to_exit = 1
            elif to_exit == 1:
                a = self.a
                b -= vert_sum / 100 / len(self.memory.keys())
                to_exit = 2
            else:
                break

    def learn(self, data, answer):
        self.memory[data] = answer
        self.count()

    def say(self, data):
        return data * self.a + self.b

    def print_say(self, data):
        print(self.say(data))

    def sure(self):
        self.count(100)

    def print_self(self):
        print(self.a)
        print(self.b)

    def test(self, data, answer):
        my_answer = self.say(data)
        difference = max(self.memory.values()) - min(self.memory.values())
        self.learn(data, answer)
        return 1 - abs(my_answer - answer) / difference

    def print_test(self, data, answer):
        print(str(self.test(data, answer) * 100) + " %")

