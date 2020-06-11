FROM sittingonthedock/vscode-containers-dotnet:lambda

RUN curl -sL https://deb.nodesource.com/setup_12.x | bash \
    && apt-get update \
    && apt-get install -y --no-install-recommends \
        gcc \
        g++ \
        make \
        nodejs \
        2>&1 \
    # Cleanup, to keep interim container small
    && apt-get autoremove -y \
    && apt-get clean -y \
    && rm -rf /var/lib/apt/lists/* \
    && npm install -g aws-cdk

ENTRYPOINT [ "sleep", "infinity" ]