from ruamel.yaml import YAML

with open('../utm.yaml', 'r') as f:
    lines = f.readlines()
i = 0
while i < len(lines):
    line = lines[i]
    colon = line.find(':')
    is_ref = line.find('$ref:')
    if len(line) > 80 and colon > 0 and is_ref == -1:
        indent = len(line) - len(line.lstrip())
        line1 = line[0:colon+1] + ' >-' + '\n'
        line2 = (' ' * (indent + 2)) + line[colon+1:]
        lines = lines[0:i] + [line1, line2] + lines[i+1:]
        i += 2
    else:
        i += 1

with open('../utm.yaml', 'w') as f:
    f.writelines(lines)

yaml = YAML()
with open('../utm.yaml', 'r') as f:
    api = yaml.load(f)

with open('../utm.yaml', 'w') as f:
    yaml.dump(api, f)
