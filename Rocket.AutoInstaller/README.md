# Rocket.AutoInstaller

It's a Module auto-installer (loader/bootstrapper), which installs RocketModFix automaticaly from GitHub, you can still use a manual way of installation, however, this one is more modern, simple and faster.

## Plans

If you want to implement one of the plans or have better ideas or ideas to change, feel free to know us about that!

- [x] Auto-Install from GitHub Releases.
- [ ] Auto-Install Local Build (so, no need to manually install RocketModFix everytime you test/update it, 1 click to build, restart server, and you're testing!).
	- [ ] Json (or other type of config) Config with Options:
  		- [ ] `EnableCustomInstallPath`: false/true (default is false).
    	- [ ] `CustomInstallPath`: path to a build of RocketModFix.
    - [ ] (Not 100% yet) We can also an option in config (`AutoInstallRocketFromExtras`) to make auto installation of Rocket (LDM) from Extras.
- [ ] Caching.
	- [ ] Check if GitHub release is newer than current cached version and ONLY then install new version.
	- [ ] For safe usage without Internet Connection.