Repository shows Rider problem where coverage does not seem to work.

Rider configured for 'continuous testing' which seems to work -- rebuilding on save.

![](Pics/01-CoverAllTests.png)

However Unit tests show no coverage info

![](Pics/02-CoverageIs-0-of-0.png)

This project is a simple reproduction case on Windows using no external libraries (beyond NUnit).

In case it is relevant, the actual usage case is with Unity libraries _present_ but not in use.  (NUnit successfully using "Standalone NUnit launcher", running all tests without any ECall errors etc so can use Rider's excellent edit and continue feature!)
