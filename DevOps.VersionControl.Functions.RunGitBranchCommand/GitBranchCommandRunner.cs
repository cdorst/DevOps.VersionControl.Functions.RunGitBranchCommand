using static DevOps.VersionControl.Functions.RunGitCommand.GitCommandRunner;

namespace DevOps.VersionControl.Functions.RunGitBranchCommand
{
    public static class GitBranchCommandRunner
    {
        private const string branch = nameof(branch);

        public static void Branch(string directory, params string[] arguments)
            => Git(directory,
                command: branch,
                arguments);
    }
}
