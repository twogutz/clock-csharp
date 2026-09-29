// defines datetime with datetime struct
DateTime time = DateTime.Now;
// sets  the delay between updates (it's literally one second
int sleepDelay = 1000;

// i'll probably make a dict to store ascii text for the characters
// so it's stylish :>

void Update() {
	if (time != DateTime.Now) { // theres this absurd thing that it prints twice the current time and this should do it
		Console.Clear();
		Console.WriteLine(time.ToString("h:mm:ss"));
		time = DateTime.Now;
	}
	Thread.Sleep(sleepDelay);
};

while (true) {
	Update();
};
