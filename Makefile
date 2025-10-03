DOTNET ?= dotnet

build:
	$(DOTNET) build

test:
	$(DOTNET) test

format fmt:
	$(DOTNET) format

.PHONY: build test format
