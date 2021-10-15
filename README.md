# LargeRepoCreator
This is just something I whipped up to test git server performance with a large repository. Using the 4 constants at the top of the file, you can configure how many files to create, how many files to put in each folder and what their file size should be. (In lines) The files with be filled with a random number of lines from War and Peace, by Leo Tolstoy. That text was chosen because its in the public domain. 


	const int filesToCreate = 5000;
	const int filesPerFolder 	= 25;
	const int minLength = 40;
	const int maxLength = 2000;


The configuration shown above will create 5000 files and put them in numbered folders, 25 files per folder. The files will contain between 40 and 2000 lines from War and Peace.
