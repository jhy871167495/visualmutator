echo %APPVEYOR_REPO_COMMIT%
@echo off
packages\MSBuild.SonarQube.Runner.Tool.1.0.0\tools\SonarQube.Scanner.MSBuild.exe begin /k:"Visualmutator-pavzaj" /d:"sonar.host.url=https://sonarqube.com" /v:"%APPVEYOR_REPO_COMMIT%" /d:"sonar.links.scm=https://github.com/pavzaj/visualmutator" /d:"sonar.cs.opencover.reportsPaths=OpencoverTestCoverageReport.xml" /d:"sonar.login=%SONARQUBE_TOKEN%"